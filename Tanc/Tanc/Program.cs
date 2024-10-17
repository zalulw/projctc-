using Tanc.Database.Entities;

using var dbContext = new Tanc.Database.ApplicationDbContext();
await AddCompetitionToDbAsync();

async Task AddCompetitionToDbAsync()
{
    CompetitionEntity competition = new CompetitionEntity
    {
        Name = "Dance Dance Dance",
        StartDate = "2024.12.05",
        EndDate = "2024.12.08",
        Street = new StreetEntity
        {
            StreetName = "Alma u.",
            DoorNumber = 34,
            City = new CityEntity
            {
                PostalCode = 6000,
                CityName = "Kecskemét",
                Country = new CountryEntity
                {
                    CountryName = "Magyarország",
                },
            },
        },
        Teams = new List<TeamEntity>()
        {
            new TeamEntity()
            {
                TeamName = "Rising Stars",
                Choreographer = "Balaton Renáta",
                Points = 43,
                Country = new CountryEntity
                {
                    CountryName = "Magyarország",
                },
                Members = new List<MemberEntity>()
                {
                    new MemberEntity
                    {
                        Name = "Ács Zoltán",
                        Sex = "Férfi",
                        DateOfBirth = "2001-11-07",
                        Street = new StreetEntity
                        {
                            StreetName = "Velnök u.",
                            DoorNumber = 26,
                            City = new CityEntity
                            {
                                PostalCode = 6900,
                                CityName = "Makó",
                                Country = new CountryEntity
                                {
                                    CountryName = "Magyarország",
                                },
                            },
                        },
                    },
                    new MemberEntity
                    {
                        Name = "Karasz Máté",
                        Sex = "Férfi",
                        DateOfBirth = "2001-09-14",
                        Street = new StreetEntity
                        {
                            StreetName = "Szegedi u.",
                            DoorNumber = 18,
                            City = new CityEntity
                            {
                                PostalCode = 6900,
                                CityName = "Makó",
                                Country = new CountryEntity
                                {
                                    CountryName = "Magyarország",
                                },
                            },
                        },
                    },
                    new MemberEntity
                    {
                        Name = "Karasz Endre",
                        Sex = "Férfi",
                        DateOfBirth = "2001-06-01",
                        Street = new StreetEntity
                        {
                            StreetName = "Almási u.",
                            DoorNumber = 29,
                            City = new CityEntity
                            {
                                PostalCode = 6900,
                                CityName = "Makó",
                                Country = new CountryEntity
                                {
                                    CountryName = "Magyarország",
                                },
                            },
                        },
                    }
                }
            },
            new TeamEntity()
            {
                TeamName = "The Champions",
                Choreographer = "Kovács István",
                Points = 20,
                Country = new CountryEntity
                {
                    CountryName = "Magyarország",
                },
                Members = new List<MemberEntity>()
                {
                    new MemberEntity
                    {
                        Name = "Kathi Béla",
                        Sex = "Férfi",
                        DateOfBirth = "2002-02-22",
                        Street = new StreetEntity
                        {
                            StreetName = "Barack u.",
                            DoorNumber = 21,
                            City = new CityEntity
                            {
                                PostalCode = 6000,
                                CityName = "Kecskemét",
                                Country = new CountryEntity
                                {
                                    CountryName = "Magyarország",
                                },
                            },
                        },
                    },
                    new MemberEntity
                    {
                        Name = "Bartos Cs. István",
                        Sex = "Férfi",
                        DateOfBirth = "2000-08-21",
                        Street = new StreetEntity
                        {
                            StreetName = "Fenyő u.",
                            DoorNumber = 11,
                            City = new CityEntity
                            {
                                PostalCode = 6000,
                                CityName = "Kecskemét",
                                Country = new CountryEntity
                                {
                                    CountryName = "Magyarország",
                                },
                            },
                        },
                    },
                    new MemberEntity
                    {
                        Name = "Béla Bá",
                        Sex = "Férfi",
                        DateOfBirth = "2001-02-12",
                        Street = new StreetEntity
                        {
                            StreetName = "Kereszt u.",
                            DoorNumber = 42,
                            City = new CityEntity
                            {
                                PostalCode = 6000,
                                CityName = "Kecskemét",
                                Country = new CountryEntity
                                {
                                    CountryName = "Magyarország",
                                },
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