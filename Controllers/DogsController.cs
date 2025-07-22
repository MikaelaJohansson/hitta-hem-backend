using Microsoft.AspNetCore.Mvc;
using HittaHem.Models;
using HittaHem.Services;

namespace HittaHem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DogsController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Dog>> GetAll() => DogService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Dog> GetById(int id)
    {
        var dog = DogService.GetById(id);
        if (dog == null) return NotFound();
        return Ok(dog);
    }
}
