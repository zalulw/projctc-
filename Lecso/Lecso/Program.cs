


using Lecso.Database.Entities;

using var dbContext = new ApplicationDbContext();


async Task AddCompetitionToDb()
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
                        TeamId = 1
                    },
                    new MemberEntity
                    {
                        Name = "Karasz máté",
                        TeamId = 1
                    },
                    new MemberEntity
                    {
                        Name = "Karasz Endre",
                        TeamId = 1
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
                        TeamId = 2
                    },
                    new MemberEntity
                    {
                        Name = "Bartos Cs István",
                        TeamId = 2
                    },
                    new MemberEntity
                    {
                        Name = "Béla Bá",
                        TeamId = 2
                    }
                }
            }
        }
        
    };
    await dbContext.Competitions.AddAsync(competition);
    await dbContext.SaveChangesAsync();

}


