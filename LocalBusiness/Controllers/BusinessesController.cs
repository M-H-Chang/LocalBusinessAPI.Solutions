using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusiness.Models;
using System.Linq;

namespace LocalBusiness.Controllers
{
  [Route("api/controller")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly LocalBusinessContext _db;
    public BusinessesController(LocalBusinessContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get(string name)
    {
      var query = _db.Businesses.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
    }
  }
}