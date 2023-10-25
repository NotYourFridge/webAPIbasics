using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace webAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DocentController : ControllerBase
{

    private SchoolContext _context;
    public DocentController(SchoolContext context)
    {
        _context = context;

    }

    [HttpGet()]
    public IEnumerable<Docent> Get()
    {
        return _context.docenten.Include(d => d.Begeleidt).ToList();
    }

    [HttpPost]
    [Route("NieuweStudent")]
    public void Post(Docent d)
    {
        _context.docenten.Add(d);
        _context.SaveChanges();

    }

}
