using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.api.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private readonly DataContext _context;
        public ValueController(DataContext context)
        {
            _context = context;
        }
       
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);

        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value =await _context.Values.FirstOrDefaultAsync(x=> x.Id == id);
            return Ok(value);

        }
    }
}