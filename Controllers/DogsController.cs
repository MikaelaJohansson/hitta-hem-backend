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



    [HttpPost("upload")]
    [RequestSizeLimit(2 * 1024 * 1024)] // Max 2MB
    public IActionResult UploadDog(
        [FromForm] DogUploadDto dogDto,
        IFormFile imageFile)
    {
        if (imageFile == null || imageFile.Length == 0)
            return BadRequest("Ingen bild bifogad.");

        try
        {
            var newDog = DogService.CreateDogFromUpload(dogDto, imageFile);
            DogService.Add(newDog);

            return CreatedAtAction(nameof(GetById), new { id = newDog.Id }, newDog);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromForm] DogUploadDto dto, IFormFile? imageFile)
    {
        var updatedDog = DogService.Update(id, dto, imageFile);
        return updatedDog != null ? Ok(updatedDog) : NotFound();
    }



    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var removed = DogService.Delete(id);
        return removed ? Ok() : NotFound();
    }

    [HttpPost("interest/{id}")]
    public IActionResult RegisterInterest(int id)
    {
        var dog = DogService.GetById(id);
        if (dog == null) return NotFound();

        dog.InterestCount++;
        return Ok(dog.InterestCount);
    }



}
