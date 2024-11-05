using Atletika.Database.Entities;

using var dbContext = new Atletika.Database.ApplicationDbContext();
await AddCompetitionToDbAsync();

async Task AddCompetitionToDbAsync()
{
    CityEntity city = new CityEntity
    {
        Name = "Budapest",
        PostalCode = 1011
    };
    await dbContext.Cities.AddAsync(city);

    StreetEntity street = new StreetEntity
    {
        Name = "Andrássy út",
        HouseNumber = 15,
        City = city
    };
    await dbContext.Streets.AddAsync(street);

    ClubEntity club = new ClubEntity
    {
        Name = "Budapest Athletics Club",
        Email = "contact@budapestathletics.hu",
        PhoneNumber = "+36 30 123 4567",
        Street = street
    };
    await dbContext.Clubs.AddAsync(club);

    AthleteEntity athlete1 = new AthleteEntity
    {
        Name = "Kovács Péter",
        Gender = "Male",
        DateOfBirth = "1999-04-15",
        Street = street,
        Club = club
    };

    AthleteEntity athlete2 = new AthleteEntity
    {
        Name = "Szabó Anna",
        Gender = "Female",
        DateOfBirth = "2002-09-05",
        Street = street,
        Club = club
    };

    await dbContext.Athletes.AddRangeAsync(athlete1, athlete2);

    EventEntity event1 = new EventEntity
    {
        Name = "100m Sprint",
        Category = "Track",
        Gender = "Male"
    };

    EventEntity event2 = new EventEntity
    {
        Name = "Long Jump",
        Category = "Field",
        Gender = "Female"
    };

    await dbContext.Events.AddRangeAsync(event1, event2);

    CompetitionEntity competition = new CompetitionEntity
    {
        Name = "Budapest National Athletics Meet",
        Year = 2024,
        StartDate = "2024-08-12",
        EndDate = "2024-08-14",
        Street = street
    };
    await dbContext.Competitions.AddAsync(competition);

    EnrollmentEntity enrollment1 = new EnrollmentEntity
    {
        Athlete = athlete1,
        Event = event1,
        Competition = competition
    };

    EnrollmentEntity enrollment2 = new EnrollmentEntity
    {
        Athlete = athlete2,
        Event = event2,
        Competition = competition
    };

    await dbContext.Enrollments.AddRangeAsync(enrollment1, enrollment2);

    await dbContext.SaveChangesAsync();
}
