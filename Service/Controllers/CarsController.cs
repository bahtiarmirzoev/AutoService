using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceDataLayer.Models;
using System.Net;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars()
        {
            try
            {
                var cars = await _context.Cars.Include(c => c.User).Include(c => c.Status).ToListAsync();
                return Ok(cars);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(Guid id)
        {
            try
            {
                var car = await _context.Cars.Include(c => c.User).Include(c => c.Status).FirstOrDefaultAsync(c => c.Id == id);
                if (car == null) return NotFound($"Car with ID {id} not found.");

                return Ok(car);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Car>> CreateCar(Car car)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                _context.Cars.Add(car);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCar), new { id = car.Id }, car);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCar(Guid id, Car car)
        {
            if (id != car.Id) return BadRequest("Car ID mismatch.");
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
                    return NotFound($"Car with ID {id} not found.");

                throw;
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        // Только Admin может менять статус автомобиля
        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateCarStatus(Guid id, [FromBody] CarStatusEnum newStatus, [FromHeader] string role)
        {
            if (role != "Admin")
                return Forbid("Only Admins can change the car status.");

            try
            {
                var car = await _context.Cars.FindAsync(id);
                if (car == null) return NotFound($"Car with ID {id} not found.");

                var status = await _context.CarStatuses.FirstOrDefaultAsync(s => s.StatusName == newStatus);
                if (status == null) return NotFound("Status not found.");

                car.StatusId = status.Id;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(Guid id)
        {
            try
            {
                var car = await _context.Cars.FindAsync(id);
                if (car == null) return NotFound($"Car with ID {id} not found.");

                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }
    }
}
