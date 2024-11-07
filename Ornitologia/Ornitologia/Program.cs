using Microsoft.Identity.Client;
using Ornitologia.Database.Entities;

using var dbContext = new Ornitologia.Database.ApplicationDbContext();
await AddNoteToDbAsync();

async Task AddNoteToDbAsync()
{
    var street = new StreetEntity
    {
        PostalCode = 37501,
        StreetName = "Groove St.",
        HouseNumber = 12,
        City = new CityEntity
        {
            CityName = "Memphis"
        }
    };

    var member = new MemberEntity
    {
        MembershipCardNumber = 1452812,
        Name = "Karasz Máté",
        Street = street,
        StartOfMembership = "2020.10.05",
        EndOfMembership = "2025.10.05"
    };

    await dbContext.Members.AddAsync(member);
    await dbContext.SaveChangesAsync();

    var tribe = new TribeEntity
    {
        TribeName = "Corvus"
    };
    await dbContext.Tribes.AddAsync(tribe);
    await dbContext.SaveChangesAsync();

    var subclass = new SubclassEntity
    {
        SubclassName = "Corvinae",
        TribeId = tribe.Id
    };
    await dbContext.Subclasses.AddAsync(subclass);
    await dbContext.SaveChangesAsync();

    var birdclass = new ClassEntity
    {
        ClassName = "Aves",
        SubclassId = subclass.Id
    };
    await dbContext.Classes.AddAsync(birdclass);
    await dbContext.SaveChangesAsync();

    var species = new SpeciesEntity
    {
        SpeciesName = "Corvus brachyrhynchos",
        ClassId = birdclass.Id
    };


    await dbContext.Species.AddAsync(species);
    await dbContext.SaveChangesAsync();



    var note = new NoteEntity
    {
        Bird = new BirdEntity
        {
            RingNumber = 1241,
            SpeciesId = species.Id,
            MemberId = member.MembershipCardNumber,
            DateOfRinging = "2022.05.21",
            WhereRinged = "Lisbon, Portugal, Parque de Apoló",
        },
        Member = member,
        Location = new StreetEntity
        {
            PostalCode = 4128,
            StreetName = "utca street",
            HouseNumber = 0,
            City = new CityEntity
            {
                CityName = "Brisbane"
            }
        },
        Date = "2024.5.21."
    };

    await dbContext.Notes.AddAsync(note);
    await dbContext.SaveChangesAsync();
}