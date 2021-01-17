using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NEST.Data;
using Microsoft.EntityFrameworkCore;
using NEST.Models;
namespace NEST.Controllers
{
    [Route("api/[controller]")]
    public class IsoPointController : Controller
    {
        private readonly DatabaseContext _db;
        public IsoPointController(DatabaseContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _db.IsolationPointList.ToListAsync());//await db.IsolationPointList.ToListAsync()

        }
    }
}
