using HittaHem.Data;
using HittaHem.Models;

namespace HittaHem.Seed;

public static class DogSeeder
{
    public static void SeedDogs(HittaHemDbContext context)
    {
        if (context.Dogs.Any()) return; 

        var dogs = new List<Dog>
        {
            new Dog { Name = "Bella", Age = 2, Sex = "Hona", Breed = "Labrador", ImageUrl = "images/dog-bella.jpg", Description = "Saga är en pigg och glad tjej..." },
            new Dog { Name = "Ella", Age = 8, Sex = "Hona", Breed = "Blandras", ImageUrl = "images/dog-ella.jpg", Description = "Ella är en klok och trygg..." },
            new Dog { Name = "Mell", Age = 3, Sex = "Hona", Breed = "Chihuahua", ImageUrl = "images/dog-mell.jpg", Description = "Mell är en liten chihuahuaflicka..." },
            new Dog { Name = "Uffe", Age = 6, Sex = "Hane", Breed = "Engelsk bulldog", ImageUrl = "images/dog-uffe.jpg", Description = "Uffe är en trygg och charmig..." },
            new Dog { Name = "Olle", Age = 3, Sex = "Hane", Breed = "Border collie", ImageUrl = "images/dog-olle.jpg", Description = "Olle är en alert och arbetsglad..." },
            new Dog { Name = "Klara", Age = 8, Sex = "Hona", Breed = "Blandras", ImageUrl = "images/dog-klara.jpg", Description = "Klara är en klok och vänlig dam..." },
            new Dog { Name = "Kalle", Age = 4, Sex = "Hane", Breed = "Blandras", ImageUrl = "images/dog-kalle.jpg", Description = "Kalle är en glad och livfull..." },
            new Dog { Name = "Linda", Age = 5, Sex = "Hona", Breed = "Blandras", ImageUrl = "images/dog-linda.jpg", Description = "Linda är en vänlig och klok..." },
            new Dog { Name = "Leo", Age = 1, Sex = "Hane", Breed = "Labrador", ImageUrl = "images/dog-leo.jpg", Description = "Leo är en ung, chokladbrun labrador..." },
            new Dog { Name = "Alex", Age = 6, Sex = "Hane", Breed = "Blandras", ImageUrl = "images/dog-alex.jpg", Description = "Alex är en liten kille på sex år..." },
            new Dog { Name = "Tor", Age = 3, Sex = "Hane", Breed = "Blandras", ImageUrl = "images/dog-tor.jpg", Description = "Tor är en livlig och glad..." },
            new Dog { Name = "Mats", Age = 10, Sex = "Hane", Breed = "Blandras", ImageUrl = "images/dog-mats.jpg", Description = "Lilla Mats är en äldre herre..." },
            new Dog { Name = "Hilda", Age = 9, Sex = "Hona", Breed = "Beagle", ImageUrl = "images/dog-hilda.jpg", Description = "Hilda är en klok och vänlig..." }
        };

        context.Dogs.AddRange(dogs);
        context.SaveChanges();
    }
}
