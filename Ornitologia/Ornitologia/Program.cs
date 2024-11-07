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
        MembershipCardNumber = 145271,
        Name = "Karasz Máté",
        Street = street,
        StartOfMembership = "2020.10.05",
        EndOfMembership = "2025.10.05"
    };

    await dbContext.Members.AddAsync(member);
    await dbContext.SaveChangesAsync();

    var note = new NoteEntity
    {
        Bird = new BirdEntity
        {
            RingNumber = 1241,
            SpeciesId = 1, 
            MemberId = member.MembershipCardNumber, 
            StreetId = street.Id, 
            DateOfRinging = "2022.05.21",
            WhereRinged = "New Street", 
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