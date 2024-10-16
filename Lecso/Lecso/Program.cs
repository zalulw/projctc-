using Lecso.Database.Entities;

using var dbContext = new ApplicationDbContext();
await AddCompetitionToDbAsync();

async Task AddCompetitionToDbAsync()
{
    CompetitionEntity competition = new CompetitionEntity
    {
        Name = "Dance Dance Revolution",
        Date = "2024.12.05",
        Location = new LocationEntity
        {
            PostalCode = 6000,
            CityName = "Kecskemét",
            StreetName = "Marcius utca",
            HouseNumber = 34
        },

        Judges = new List<JudgeEntity>()
        {
            new JudgeEntity()
            {
                Name = "Czegle Márton",
                PhoneNumber = "+36305446037",
                Email = "nyaritibor@gmail.com"
            },
            new JudgeEntity()
            {
                Name = "Biro Jozsef",
                PhoneNumber = "+36702445132",
                Email = "birojozsef@gmail.com"
            }
        },

        Teams = new List<TeamEntity>()
        {
            new TeamEntity()
            {
                TeamName = "lecso fozok",
                Points = 43,
                Members = new List<MemberEntity>()
                {
                    new MemberEntity
                    {
                        Name = "Bas Zoltán",
                    },
                    new MemberEntity
                    {
                        Name = "Karasz máté",
                    },
                    new MemberEntity
                    {
                        Name = "Karasz Endre",
                    }
                }
            },
            new TeamEntity()
            {
                TeamName = "lecso kiralyok",
                Points = 20,
                Members = new List<MemberEntity>()
                {
                    new MemberEntity
                    {
                        Name = "Kathi Béla",
                    },
                    new MemberEntity
                    {
                        Name = "Bartos Cs István",
                    },
                    new MemberEntity
                    {
                        Name = "Béla Bá",
                    }
                }
            }
        }
        
    };
    await dbContext.Competitions.AddAsync(competition);
    await dbContext.SaveChangesAsync();


}


