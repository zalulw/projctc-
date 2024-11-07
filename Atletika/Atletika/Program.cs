using Atletika.Database.Entities;

using var dbContext = new Atletika.Database.ApplicationDbContext();
await AddCompetitionToDbAsync();

async Task AddCompetitionToDbAsync()
{
    CompetitionEntity competition = new CompetitionEntity
    {
        Name = "Budapest National Athletics Meet",
        Year = 2024,
        StartDate = "2024-08-12",
        EndDate = "2024-08-14",
        Street = new StreetEntity
        {
            Name = "Alma u.",
            HouseNumber = 34,
            City = new CityEntity
            {
                PostalCode = 6000,
                Name = "Kecskemét",
            },
        },
        Events = new List<EventEntity>()
        {
            new EventEntity()
            {
                Category = "Futószám",
                SubCategory = "100m síkfutás",
                Gender = "Férfi",
                AgeGroup = "Ifjúsági"
            },
            new EventEntity()
            {
                Category = "Futószám",
                SubCategory = "200m síkfutás",
                Gender = "Férfi",
                AgeGroup = "Felnőtt"
            },
            new EventEntity()
            {
                Category = "Futószám",
                SubCategory = "400m síkfutás",
                Gender = "Férfi",
                AgeGroup = "Felnőtt"
            },
            new EventEntity()
            {
                Category = "Futószám",
                SubCategory = "400m síkfutás",
                Gender = "Női",
                AgeGroup = "Felnőtt"
            },
        },
        Clubs = new List<ClubEntity>()
        {
            new ClubEntity()
            {
                Name = "Budapest Athletics Club",
                Email = "contact@budapestathletics.hu",
                PhoneNumber = "+3601234567",
                Athletes = new List<AthleteEntity>()
                {
                    new AthleteEntity
                    {
                        Name = "Ács Zoltán",
                        Gender = "Férfi",
                        DateOfBirth = "2001-11-07",
                        Street = new StreetEntity
                        {
                            Name = "Velnök u.",
                            HouseNumber = 26,
                            City = new CityEntity
                            {
                                PostalCode = 6900,
                                Name = "Makó",
                            },
                        },
                    },
                    new AthleteEntity
                    {
                        Name = "Karasz Máté",
                        Gender = "Férfi",
                        DateOfBirth = "2009-09-14",
                        ResponsiblePersonName = "Karasz Károly",
                        ResponsiblePersonPhone = "+36302029827",
                        Street = new StreetEntity
                        {
                            Name = "Szegedi u.",
                            HouseNumber = 18,
                            City = new CityEntity
                            {
                                PostalCode = 6900,
                                Name = "Makó",
                            },
                        },
                    },
                    new AthleteEntity
                    {
                        Name = "Karasz Endre",
                        Gender = "Férfi",
                        DateOfBirth = "2001-06-01",
                        Street = new StreetEntity
                        {
                            Name = "Almási u.",
                            HouseNumber = 29,
                            City = new CityEntity
                            {
                                PostalCode = 6900,
                                Name = "Makó",
                            },
                        },
                    }
                }
            },
            new ClubEntity()
            {
                Name = "The Champions",
                Email = "Kovács István",
                PhoneNumber = "",
                Athletes = new List<AthleteEntity>()
                {
                    new AthleteEntity
                    {
                        Name = "Kathi Béla",
                        Gender = "Férfi",
                        DateOfBirth = "2002-02-22",
                        Street = new StreetEntity
                        {
                            Name = "Barack u.",
                            HouseNumber = 21,
                            City = new CityEntity
                            {
                                PostalCode = 6000,
                                Name = "Kecskemét",
                            },
                        },
                    },
                    new AthleteEntity
                    {
                        Name = "Bartos Cs. István",
                        Gender = "Férfi",
                        DateOfBirth = "2000-08-21",
                        Street = new StreetEntity
                        {
                            Name = "Fenyő u.",
                            HouseNumber = 11,
                            City = new CityEntity
                            {
                                PostalCode = 6000,
                                Name = "Kecskemét",
                            },
                        },
                    },
                    new AthleteEntity
                    {
                        Name = "Béla Bá",
                        Gender = "Férfi",
                        DateOfBirth = "2001-02-12",
                        Street = new StreetEntity
                        {
                            Name = "Kereszt u.",
                            HouseNumber = 42,
                            City = new CityEntity
                            {
                                PostalCode = 6000,
                                Name = "Kecskemét",
                            },
                        },
                    }
                }
            }
        }

    };
    await dbContext.Competitions.AddAsync(competition);
    await dbContext.SaveChangesAsync();

}