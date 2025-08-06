using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HittaHem.Models;
using HittaHem.Data;

namespace HittaHem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DogsController : ControllerBase
{
    private readonly HittaHemDbContext _context;

    public DogsController(HittaHemDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Dog>>> GetAll()
    {
        return await _context.Dogs.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Dog>> GetById(int id)
    {
        var dog = await _context.Dogs.FindAsync(id);
        return dog == null ? NotFound() : Ok(dog);
    }

    [HttpPost("upload")]
    [RequestSizeLimit(2 * 1024 * 1024)]
    public async Task<IActionResult> UploadDog(
        [FromForm] DogUploadDto dogDto,
        IFormFile imageFile)
    {
        if (imageFile == null || imageFile.Length == 0)
            return BadRequest("Ingen bild bifogad.");

        var allowedTypes = new[] { "image/jpeg", "image/png" };
        if (!allowedTypes.Contains(imageFile.ContentType))
            return BadRequest("Endast JPG eller PNG tillåts.");

        using var ms = new MemoryStream();
        await imageFile.CopyToAsync(ms);
        var imageBytes = ms.ToArray();

        var dog = new Dog
        {
            Name = dogDto.Name,
            Age = dogDto.Age,
            Sex = dogDto.Sex,
            Breed = dogDto.Breed,
            Description = dogDto.Description,
            ImageUrl = $"data:{imageFile.ContentType};base64,{Convert.ToBase64String(imageBytes)}",
            InterestCount = 0
        };

        _context.Dogs.Add(dog);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = dog.Id }, dog);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromForm] DogUploadDto dto, IFormFile? imageFile)
    {
        var dog = await _context.Dogs.FindAsync(id);
        if (dog == null) return NotFound();

        dog.Name = dto.Name;
        dog.Age = dto.Age;
        dog.Sex = dto.Sex;
        dog.Breed = dto.Breed;
        dog.Description = dto.Description;

        if (imageFile != null)
        {
            var allowedTypes = new[] { "image/jpeg", "image/png" };
            if (!allowedTypes.Contains(imageFile.ContentType))
                return BadRequest("Endast JPG eller PNG tillåts.");

            using var ms = new MemoryStream();
            await imageFile.CopyToAsync(ms);
            var imageBytes = ms.ToArray();

            dog.ImageUrl = $"data:{imageFile.ContentType};base64,{Convert.ToBase64String(imageBytes)}";
        }

        await _context.SaveChangesAsync();
        return Ok(dog);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var dog = await _context.Dogs.FindAsync(id);
        if (dog == null) return NotFound();

        _context.Dogs.Remove(dog);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPost("interest/{id}")]
    public async Task<IActionResult> RegisterInterest(int id)
    {
        var dog = await _context.Dogs.FindAsync(id);
        if (dog == null) return NotFound();

        dog.InterestCount++;
        await _context.SaveChangesAsync();

        return Ok(dog.InterestCount);
    }
}
