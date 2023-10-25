using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{

    private SchoolContext _context;        
    public StudentController(SchoolContext context, IMijnConfiguratie configuratie, IConfiguration c)
    {
       _context = context;
       System.Console.WriteLine(configuratie.OperatingSystem());
       System.Console.WriteLine(c.GetValue<string>("AllowedHosts"));
    }

    [HttpGet()]
    [Route("VraagOp")]
    public IEnumerable<Student> Get()
    {
        return _context.studenten.ToList();
    }

    [HttpPost]
    [Route("NieuweStudent")]
    public void Post([Bind("Name")]Student s)
    {
        _context.studenten.Add(s);
        _context.SaveChanges();

    }

}
