namespace Chores.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{

  private readonly ChoresService _cs;

  [HttpGet]
  public ActionResult<List<Chore>> GetChores()
  {
    try
    {
      var chores = _cs.GetChores();
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpGet("{id}")]
  public ActionResult<Chore> GetChoreByID(string id)
  {
    try
    {
      var chore = _cs.GetChoreById(id);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpPost]
  public ActionResult<Chore> Create([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _cs.AddChore(choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete]
  public ActionResult<Chore> Delete([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _cs.AddChore(choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  public ChoresController(ChoresService cs){
    _cs = cs;
  }

}