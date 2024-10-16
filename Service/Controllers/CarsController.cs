using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceDataLayer;
using ServiceDataLayer.Models;
using ServiceDataLayer.Models.DTOs;
using System.Net;
using System.Linq;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ServiceDBContext _context;

        public CarsController(ServiceDBContext context)
        {
            _context = context;
        }

        // GET api/cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarDTO>>> GetCars()
        {
            try
            {
                var cars = await _context.Cars.Include(c => c.User).Include(c => c.Status)
                    .Select(c => new CarDTO
                    {
                        Id = c.Id,
                        LicensePlate = c.LicensePlate,
                        Model = c.Model,
                        Brand = c.Make 
                    })
                    .ToListAsync();

                return Ok(cars);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { message = "Error: Could not retrieve cars.", details = ex.Message });
            }
        }

        // GET api/cars/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CarDTO>> GetCar(Guid id)
        {
            try
            {
                var car = await _context.Cars.Include(c => c.User).Include(c => c.Status)
                    .Where(c => c.Id == id)
                    .Select(c => new CarDTO
                    {
                        Id = c.Id,
                        LicensePlate = c.LicensePlate,
                        Model = c.Model,
                        Brand = c.Make // Assuming "Make" is the Brand in your model
                    })
                    .FirstOrDefaultAsync();

                if (car == null)
                    return NotFound(new { message = $"Car with ID {id} not found." });

                return Ok(car);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { message = "Error: Could not retrieve car.", details = ex.Message });
            }
        }

        // POST api/cars
        [HttpPost]
        public async Task<ActionResult<CarDTO>> CreateCar(Car car)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                _context.Cars.Add(car);
                await _context.SaveChangesAsync();

                // Return the created car as a DTO
                var carDTO = new CarDTO
                {
                    Id = car.Id,
                    LicensePlate = car.LicensePlate,
                    Model = car.Model,
                    Brand = car.Make
                };

                return CreatedAtAction(nameof(GetCar), new { id = car.Id }, carDTO);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { message = "Error: Could not create car.", details = ex.Message });
            }
        }

        // PUT api/cars/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCar(Guid id, Car car)
        {
            if (id != car.Id) return BadRequest(new { message = "Car ID mismatch." });
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                _context.Entry(car).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Cars.Any(e => e.Id == id))
                    return NotFound(new { message = $"Car with ID {id} not found." });

                throw;
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { message = "Error: Could not update car.", details = ex.Message });
            }
        }

        

        // DELETE api/cars/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(Guid id)
        {
            try
            {
                var car = await _context.Cars.FindAsync(id);
                if (car == null) return NotFound(new { message = $"Car with ID {id} not found." });

                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { message = "Error: Could not delete car.", details = ex.Message });
            }
        }
    }
}
