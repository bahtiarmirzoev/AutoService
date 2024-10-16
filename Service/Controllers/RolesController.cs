using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceDataLayer;
using ServiceDataLayer.Models;
using System.Net;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ServiceDBContext _context;

        public RolesController(ServiceDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            try
            {
                var roles = await _context.Roles.ToListAsync();
                if (!roles.Any())
                    return NotFound("No roles found.");

                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> GetRole(Guid id)
        {
            try
            {
                var role = await _context.Roles.FindAsync(id);
                if (role == null) return NotFound($"Role with ID {id} not found.");

                return Ok(role);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Role>> CreateRole(Role role)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                _context.Roles.Add(role);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetRole), new { id = role.RoleId }, role);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(Guid id, Role role)
        {
            if (id != role.RoleId) return BadRequest("Role ID mismatch.");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                _context.Entry(role).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Roles.Any(e => e.RoleId == id))
                    return NotFound($"Role with ID {id} not found.");

                throw;
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(Guid id)
        {
            try
            {
                var role = await _context.Roles.FindAsync(id);
                if (role == null) return NotFound($"Role with ID {id} not found.");

                _context.Roles.Remove(role);
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
