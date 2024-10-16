using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceDataLayer;
using ServiceDataLayer.Models;
using System.Net;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceTypesController : ControllerBase
    {
        private readonly ServiceDBContext _context;

        public ServiceTypesController(ServiceDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceType>>> GetServiceTypes()
        {
            try
            {
                var serviceTypes = await _context.ServiceTypes.ToListAsync();
                if (!serviceTypes.Any())
                    return NotFound("No service types found.");

                return Ok(serviceTypes);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceType>> GetServiceType(Guid id)
        {
            try
            {
                var serviceType = await _context.ServiceTypes.FindAsync(id);
                if (serviceType == null) return NotFound($"Service type with ID {id} not found.");

                return Ok(serviceType);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<ServiceType>> CreateServiceType(ServiceType serviceType)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                _context.ServiceTypes.Add(serviceType);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetServiceType), new { id = serviceType.Id }, serviceType);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateServiceType(Guid id, ServiceType serviceType)
        {
            if (id != serviceType.Id) return BadRequest("Service type ID mismatch.");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                _context.Entry(serviceType).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.ServiceTypes.Any(e => e.Id == id))
                    return NotFound($"Service type with ID {id} not found.");

                throw;
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceType(Guid id)
        {
            try
            {
                var serviceType = await _context.ServiceTypes.FindAsync(id);
                if (serviceType == null) return NotFound($"Service type with ID {id} not found.");

                _context.ServiceTypes.Remove(serviceType);
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
