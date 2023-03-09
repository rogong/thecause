using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheCause.Data;
using TheCause.Models;

namespace TheCause.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SignsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SignsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<APISignController>
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Sign>>> GetSigns(int id)
        {
            var signs = await _context.Signs.
                Where(s => s.PetitionId == id).
                ToListAsync();

            return Ok(signs);
        }

    }
}
