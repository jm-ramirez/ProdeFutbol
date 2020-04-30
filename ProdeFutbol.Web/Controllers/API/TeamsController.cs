using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdeFutbol.Web.Data;
using ProdeFutbol.Web.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdeFutbol.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly DataContext _context;

        public TeamsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TeamEntity> GetTeams()
        {
            return _context.Teams.OrderBy(t => t.Name);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamEntity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TeamEntity teamEntity = await _context.Teams.FindAsync(id);

            if (teamEntity == null)
            {
                return NotFound();
            }

            return Ok(teamEntity);
        }

    }
}