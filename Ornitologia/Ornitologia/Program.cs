using Ornitologia.Database.Entities;


using var dbContext = new Ornitologia.Database.ApplicationDbContext();


async Task AddBirdToDbAsync()
{
    var bird = new BirdEntity
    {
        RingNumber = 1241,
        Species = new SpeciesEntity
        {
            SpeciesName = "Corvus brachyrhynchos",
            Class = new ClassEntity
            {
                ClassName = "Aves",
                Subclass = new SubclassEntity
                {
                    SubclassName = "Neognathae",
                    Tribe = new TribeEntity
                    {
                        TribeName = "Corvidae"
                    }
                }
            }
        },
        WhoRinged = new MemberEntity
        {
            MembershipCardNumber = 145271,
            Name = "Karasz Máté",
            Street = new StreetEntity
            {
                PostalCode = 37501,
                StreetName = "Groove St.",
                HouseNumber = 12,
                City = new CityEntity
                {
                    CityName = "Memphis"
                }
            },
            StartOfMembership = "2020.10.05",
            EndOfMembership = "2025.10.05"
        },
        WhereRinged = new StreetEntity
        {
            PostalCode = 37501,
            StreetName = "New Street",
            HouseNumber = 0,
            City = new CityEntity
            {
                CityName = "Memphis"
            }
        },
        DateOfRinging = "2022.05.21",
        Note = new NoteEntity
        {

        }
    };
}
