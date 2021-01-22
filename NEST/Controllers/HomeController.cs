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
        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //     return Ok(await _db.IsolationPointList.ToListAsync());//await db.IsolationPointList.ToListAsync()
        //}

        [HttpGet]
        public async Task<IActionResult> ReturnSpecificResult(int udc = 0, int isolationuid=0, 
            string parentsystem=null, string isolationpoint=null, string description=null) {
             var SpecificResult = await _db.IsolationPointList
                .Where(x => x.UDC.Equals(udc) || udc == 0)
                .Where(x => x.ParentSystem.Contains(parentsystem) || parentsystem==null)
                .Where(x => x.IsolationPoint.Contains(isolationpoint) || isolationpoint==null)
                .Where(x => x.Description.Contains(description)|| description==null)
                .Where(x => x.IsolationUID.Equals(isolationuid) || isolationuid == 0)
                //.Where(x => x.UDC.Contains(udc) || udc == 0) ->Not yet working becuase UDC is primary key.
                .ToListAsync();
            return Ok(SpecificResult);
        }
    }
}
