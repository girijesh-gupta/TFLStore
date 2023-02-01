using Microsoft.AspNetCore.Mvc;

namespace HRWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HRController : ControllerBase
{
    

    private readonly ILogger<HRController> _logger;

    public HRController(ILogger<HRControllerr> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAllEmployees")]
    public IEnumerable<Employee> Get()
    {
        List<Employee>employees =HRDBManager.GetAll();
        return employees.ToArray();
    }
     [HttpGet]
    [Route("{id}")]
    public ActionResult<Employee>  GetById(int id){
       Employee emp=  HRDBManager.GetById(id);
       return emp;
    }
}
