using HittaHem.Models;

namespace HittaHem.Services;

public static class DogService
{
    static List<Dog> Dogs { get; }

    static DogService()
    {
        Dogs = new List<Dog>
        {
            new Dog
            {
                Id = 1,
                Name = "Bella",
                Age = 2,
                Sex = "Hona",
                Breed = "Labrador",
                ImageUrl = "/images/dog-bella.jpg",

                Description ="""
                Saga är en pigg och glad tjej på sju år som har mycket kärlek och bus kvar att ge. 
                Hon är en charmig tjej som älskar att hänga med sina människor och hitta på roliga saker tillsammans. 
                Saga är nyfiken på världen och tycker att livet ska vara ett äventyr, gärna med massor av godis, lek och mysstunder.
                Promenader är en av hennes favoritsysslor, särskilt när hon får strosa runt i sin egen takt och använda sin duktiga nos. 
                Hon älskar att nosa, spåra och söka efter godis i gräset, 
                så om du gillar att hitta på enkla aktiveringar i vardagen kommer ni att bli ett toppenpar! Saga är en hund som verkligen
                uppskattar när man engagerar sig i henne, men hon är också bra på att koppla av och njuta av lugnet efter en aktiv stund.
                Med sin glada och härliga energi sprider Saga leenden omkring sig. Hon är en social och tillgiven hund och blir en trogen följeslagare i vardagen.
                """
            },
            new Dog
            {
                Id = 2,
                Name = "Ella",
                Age = 8,
                Sex = "Hona",
                Breed = "Blandras",
                ImageUrl = "/images/dog-ella.jpg",

                Description = """
                Ella är en klok och trygg blandrastjej på fem år som charmar alla med sitt lugna och vänliga sätt. 
                Hon är en hund som älskar att vara nära sina människor och tar gärna emot både kel och klappar.
                Ella trivs bäst i ett lugnt tempo och tycker om att följa med på promenader där hon får strosa i sin egen takt och nosa på alla spännande dofter. 
                Hon uppskattar mysiga stunder i soffan lika mycket som lugna aktiviteter som stillsamma lekar och enkla sökövningar.
                Trots sin lugna personlighet har Ella glimten i ögat och kan bjuda på härliga busstunder när hon känner sig trygg. 
                Hon är en lojal vän som gärna följer med i vardagens alla små äventyr, oavsett om det handlar om en promenad, en fika i parken eller en mysig hemmakväll.
                Ella söker ett hem där hon får vara en självklar del av familjen och där man uppskattar hennes lugn, kärlek och trofasta sällskap.
                """

            },
            new Dog
            {
                Id = 3,
                Name = "Mell",
                Age = 3,
                Sex = "Hona",
                Breed = "Chihuahua",
                ImageUrl = "/images/dog-mell.jpg",

                Description = """
                Mell är en liten chihuahuaflicka på tre år som charmar alla med sitt söta uttryck och stora personlighet. Hon må vara liten till storleken, 
                men i hjärtat är hon ett riktigt energiknippe som älskar att vara med där det händer. 
                Mell är en klok och nyfiken tjej som gärna följer med på promenader, särskilt när hon får upptäcka nya stigar i lugn och ro vid din sida.
                Hon uppskattar både lugna stunder i famnen och lekfulla stunder där hon får lattja runt och busa. 
                Trots sin lilla storlek har Mell en stark vilja och tycker om när man engagerar sig i henne med mjuka händer och tydliga gränser.
                Mell söker ett hem där hon får vara den lilla prinsessan i vardagen, gärna hos någon som vill ha en nära vän och följeslagare. 
                Hon trivs bäst när hon får vara med sina människor, antingen på äventyr eller när det bara är dags för en lugn mysstund i soffan.
                """

            },
            new Dog
            {
                Id = 4,
                Name = "Uffe",
                Age = 6,
                Sex = "Hane",
                Breed = "engelsk-bulldog",
                ImageUrl = "/images/dog-uffe.jpg",

                Description = """
                Uffe är en trygg och charmig engelsk bulldog på sex år som tar livet med ro. Med sitt vänliga sätt och kloka blick har han en förmåga att vinna över alla han möter, 
                gärna med en liten svansviftning och ett värmande leende. Uffe älskar det goda i livet: korta promenader i solen, en mjuk filt att ligga på och självklart en stunds kel med sina människor.
                Han är en stadig kille som uppskattar lugna hemmakvällar lika mycket som små vardagsäventyr. Uffe är en hund som gärna strosar runt i sin egen takt och njuter av varje doft längs vägen. 
                Stressar gör han inte, han tar dagen som den kommer och visar gärna att det ibland är helt okej att bara vara.
                Med sin milda personlighet och sitt stora hjärta söker Uffe ett hem där han får massor av kärlek, lugn och trygghet. 
                Han är en lojal vän som gärna håller sig nära och sprider harmoni omkring sig, en riktig gentleman i bulldogskostym.
                """

            },
            new Dog
            {
                Id = 5,
                Name = "Olle",
                Age = 3,
                Sex = "Hane",
                Breed = "Border collie",
                ImageUrl = "/images/dog-olle.jpg",

                Description = """
                Olle är en alert och arbetsglad border collie på tre år som älskar att ha något att göra. 
                Han är en smart kille med mycket energi och ett hjärta av guld. Olle trivs bäst när han får använda både kropp och knopp, oavsett om det handlar om långa promenader, 
                enkla sökövningar eller att lära sig nya trick tillsammans med sin människa.
                Med sin vakna blick och nyfikna personlighet är han alltid redo för nästa äventyr. 
                Olle är en hund som gärna samarbetar och uppskattar när man engagerar sig i honom på ett positivt och lekfullt sätt. 
                Han har lätt för att knyta band och är lojal mot dem han känner förtroende för.
                Efter en aktiv dag njuter Olle gärna av lugna stunder hemma, gärna nära sin familj. 
                Han söker ett hem som kan ge honom både kärlek, aktivitet och trygghet, och som ser honom för den fantastiska vän han är.
                """

            },
            new Dog
            {
                Id = 6,
                Name = "Klara",
                Age = 8,
                Sex = "Hona",
                Breed = "Blandras",
                ImageUrl = "/images/dog-klara.jpg",

                Description = """
                Klara är en klok och vänlig dam på åtta år som bär med sig en härlig blandning av livserfarenhet och kärlek. 
                Hon är en blandrashund med ett hjärta av guld, lojal, mjuk och trygg i sig själv. 
                Klara har sett det mesta i livet och uppskattar därför de små stunderna: en lugn promenad, 
                en varm plats att vila på, och förstås, närhet till sina människor.
                Hon älskar att ta dagen i sin egen takt och följer gärna med ut på promenader där hon får 
                nosa och upptäcka i lugn och ro. Efteråt njuter hon gärna av en mjuk plats i hemmet där 
                hon kan koppla av och bara vara. Klara är ingen hund som jagar äventyr längre, men hon uppskattar att vara med och känna sig delaktig i vardagen.
                Med sin vänliga blick och lugna närvaro blir Klara snabbt en självklar del av familjen. 
                Hon söker ett hem där hon får bli älskad för den trygga och trofasta vän hon är, 
                någon som uppskattar hennes mjuka sätt och som vill ge henne ett varmt hem att kalla sitt eget.
                """

            },
            new Dog
            {
                Id = 7,
                Name = "Kalle",
                Age = 4,
                Sex = "hane",
                Breed = "Blandras",
                ImageUrl = "/images/dog-kalle.jpg",

                Description = """
                Kalle är en glad och livfull blandrashane på fyra år med glimten i ögat och hjärtat på rätta stället. 
                Han är en social och nyfiken kille som älskar att vara med där det händer. oavsett om det är en långpromenad i skogen, 
                lek i trädgården eller en mysig stund inomhus.
                Kalle är en hund som gärna använder sin nos och sin energi på aktiveringar tillsammans med sin människa. 
                Han uppskattar när man hittar på saker ihop, som små träningspass, söklekar eller bara en rolig stund med bollkastning. 
                Men trots sin lekfulla sida kan Kalle också njuta av lugna stunder och vet hur man kopplar av när dagen går mot sitt slut.
                Han är en lojal kompis som gärna följer med på livets äventyr, en blandning av bus, hjärta och trygghet. 
                Kalle söker ett hem där han får både rörelse, kärlek och gemenskap, och där han får fortsätta vara den glada följeslagare han är.
                """

            },
            new Dog
            {
                Id = 8,
                Name = "Linda",
                Age = 5,
                Sex = "Hona",
                Breed = "Blandras",
                ImageUrl = "/images/dog-linda.jpg",

                Description = """
                Linda är en vänlig och klok blandrastjej på fem år som gärna tar livet som det kommer. 
                Hon är en mellanstor hund med ett stort hjärta och ett lugnt, tryggt sätt. 
                Linda älskar sällskap och trivs allra bäst när hon får vara nära sina människor, 
                oavsett om det handlar om promenader i naturen, små äventyr i vardagen eller lugna stunder hemma.
                Hon har ett nyfiket sinne och tycker om att utforska sin omgivning, gärna i sin egen takt. 
                Linda uppskattar aktivering som låter henne använda sitt huvud, som att nosa, spåra eller leka enkla lekar tillsammans med sin familj.
                Med sitt mjuka och balanserade sätt passar Linda perfekt i ett hem som söker en lojal och kärleksfull vän. 
                Hon är en hund som älskar närhet och som gärna knyter starka band med dem hon litar på. 
                Med Linda får du en trofast följeslagare som gärna delar både vardag och äventyr.
                """

            },
            new Dog
            {
                Id = 9,
                Name = "Leo",
                Age = 1,
                Sex = "Hane",
                Breed = "Labrador",
                ImageUrl = "/images/dog-leo.jpg",

                Description = """
                Leo är en ung, chokladbrun labradorhane på ett år som sprudlar av energi och livsglädje. 
                Han är en riktig glädjespridare med sin busiga blick och ständigt viftande svans. 
                Full av upptäckarlust älskar Leo att vara ute och röra på sig, oavsett om det är långpromenader, 
                lekar i trädgården eller att få springa fritt och nosa på allt som världen har att erbjuda.
                Trots sin unga ålder har Leo redan visat vilken smart och läraktig kille han är. Han uppskattar när man tränar tillsammans, 
                och han suger åt sig nya saker som en svamp, särskilt om det finns en godisbit som belöning. 
                Med rätt vägledning och kärlek kommer Leo att växa till en fantastisk följeslagare som gärna delar både äventyr och lugna stunder med sin familj.
                Leo söker ett aktivt hem där han får använda både kropp och knopp och där hans härliga energi tas till vara. 
                Med sitt stora hjärta och sin charm blir han snabbt en självklar del av vardagen, alltid redo för nästa äventyr!
                """

            },
            new Dog
            {
                Id = 10,
                Name = "Alex",
                Age = 6,
                Sex = "Hane",
                Breed = "Blandras",
                ImageUrl = "/images/dog-alex.jpg",

                Description = """
                Alex är en liten kille på sex år med en stor personlighet och ett varmt hjärta. 
                Trots sin nätta storlek är han en hund med mycket karaktär, trygg, nyfiken och alltid redo att hänga med på små äventyr. 
                Alex älskar promenader där han får gå i sin egen takt och nosa på omgivningen, men uppskattar lika mycket att krypa upp i knäet och bara mysa.
                Han är en social liten herre som gärna följer med på det mesta och tycker om när man ger honom tid och uppmärksamhet. 
                Alex är en trofast vän som knyter starka band med sina människor och gillar när vardagen bjuder på både rörelse och vila.
                Med sitt lugna och tillgivna sätt söker Alex ett hem där han får känna sig trygg och älskad. 
                Han trivs bäst i lugna miljöer där han får vara en del av gemenskapen och där man uppskattar hans fina balans mellan lekfullhet och mys.
                """

            },
            new Dog
            {
                Id = 11,
                Name = "Tor",
                Age = 3,
                Sex = "Hane",
                Breed = "Blandras",
                ImageUrl = "/images/dog-tor.jpg",

                Description = """
                Tor är en livlig och glad blandrashane på tre år som älskar när vardagen bjuder på äventyr. 
                Han är en nyfiken och smart kille som alltid är redo för en promenad, en rolig lek eller en stunds bus med sina människor. 
                Tor har mycket energi och trivs bäst när han får använda både kropp och huvud, gärna i form av aktivering, nosarbete eller lek.
                Trots sin pigga personlighet har Tor också en mjuk sida, han gillar när man tar sig tid för honom och uppskattar att få närhet och trygghet. 
                Han är en hund som gärna bygger starka band med sina människor och som följer dig troget när ni väl lärt känna varandra.
                Tor söker ett hem som gillar att vara aktiva tillsammans med sin hund och som vill ha en lojal kompis vid sin sida. 
                Med sin charm, energi och sitt stora hjärta kommer Tor bli en fantastisk vän att dela både vardag och äventyr med.
                """

            },
            new Dog
            {
                Id = 12,
                Name = "Mats",
                Age = 10,
                Sex = "Hane",
                Breed = "Blandras",
                ImageUrl = "/images/dog-mats.jpg",

                Description = """
                Lilla Mats är en äldre herre på tio år som bär med sig en livserfarenhet och ett hjärta fyllt av kärlek. 
                Han är en blandrashund med ett lugnt, vänligt sätt och en varm blick som säger mer än tusen ord. 
                Lilla Mats uppskattar de enkla glädjeämnena i livet, en stillsam promenad, en mjuk plats att vila på och närheten till sina människor.
                Han är ingen som stressar runt utan tar gärna dagen som den kommer, i sin egen takt. 
                Trots sina år har han fortfarande glimten i ögat och älskar när man bryr sig om honom. 
                En mjuk hand, en vänlig röst och lite sällskap betyder allt för Lilla Mats.
                Nu söker han ett hem där han får njuta av livet i lugn och ro, tillsammans med någon som uppskattar en trogen vän vid sin sida. 
                Lilla Mats är den perfekta sällskapshunden för dig som vill dela vardagen med en trygg, lojal och kärleksfull följeslagare.
                """

            },
            new Dog
            {
                Id = 13,
                Name = "Hilda",
                Age = 9,
                Sex = "Hona",
                Breed = "Beagle",
                ImageUrl = "/images/dog-hilda.jpg",

                Description = """
                Hilda är en klok och vänlig beagletik på nio år som charmar alla med sitt lugna sätt och sina nyfikna ögon. 
                Hon är en hund som gärna njuter av livets små stunder, en promenad i skogen där hon får följa spännande dofter, 
                en mjuk plats att vila på, och såklart massor av mys med sina människor.
                Som beagle älskar Hilda att använda sin nos och är alltid redo att nosa runt i sin egen takt. 
                Hon trivs bäst när dagarna bjuder på en lagom blandning av aktivitet och vila. 
                Trots sin lite äldre ålder finns nyfikenheten kvar, och hon uppskattar enkla aktiveringar som spår, nosövningar eller lugna utflykter i naturen.
                Med sin vänliga och tillgivna personlighet söker Hilda ett tryggt hem där hon får vara med och känna sig älskad. 
                Hon är en lojal och kärleksfull följeslagare som gärna håller sig nära och sprider värme i vardagen.
                """

            },
        };

    }

    public static List<Dog> GetAll() => Dogs;

    public static Dog? GetById(int id)
    {
        return Dogs.FirstOrDefault(d => d.Id == id);
    }


    private static int nextId = 14;

    public static void Add(Dog dog)
    {
        dog.Id = nextId++;
        Dogs.Add(dog);
    }

    public static Dog CreateDogFromUpload(DogUploadDto dto, IFormFile imageFile)
    {
        var allowedTypes = new[] { "image/jpeg", "image/png" };
        if (!allowedTypes.Contains(imageFile.ContentType))
            throw new Exception("Endast .jpg och .png tillåts.");

        using var ms = new MemoryStream();
        imageFile.CopyTo(ms);
        var imageBytes = ms.ToArray();

        return new Dog
        {
            Name = dto.Name,
            Age = dto.Age,
            Sex = dto.Sex,
            Breed = dto.Breed,
            Description = dto.Description,
            ImageUrl = $"data:{imageFile.ContentType};base64,{Convert.ToBase64String(imageBytes)}"
        };
    }

    public static Dog? Update(int id, DogUploadDto dto, IFormFile? imageFile)
    {
        var existingDog = Dogs.FirstOrDefault(d => d.Id == id);
        if (existingDog == null) return null;

        existingDog.Name = dto.Name;
        existingDog.Age = dto.Age;
        existingDog.Sex = dto.Sex;
        existingDog.Breed = dto.Breed;
        existingDog.Description = dto.Description;

        if (imageFile != null)
        {
            var allowedTypes = new[] { "image/jpeg", "image/png" };
            if (!allowedTypes.Contains(imageFile.ContentType))
                throw new Exception("Endast .jpg och .png tillåts.");

            using var ms = new MemoryStream();
            imageFile.CopyTo(ms);
            var imageBytes = ms.ToArray();

            existingDog.ImageUrl = $"data:{imageFile.ContentType};base64,{Convert.ToBase64String(imageBytes)}";
        }

        return existingDog;
    }

    public static bool Delete(int id)
    {
        var dog = Dogs.FirstOrDefault(d => d.Id == id);
        if (dog == null) return false;

        Dogs.Remove(dog);
        return true;
    }

}
