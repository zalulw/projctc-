using var dbContext = new ApplicationDbContext();

try
{

    //await AddFirstVehicleToDB();
    //await AddSecondVehicleToDB();

    //var vehicles = await dbContext.Vehicles.Include(vehicle => vehicle.Color)
    //                                       .Include(vehicle => vehicle.Model)
    //                                        .ThenInclude(model => model.Manufacturer)
    //                                       .ToListAsync();

    //PrintVehiclesOnConsole(vehicles);

    var vehicle = await dbContext.Vehicles.Include(vehicle => vehicle.Color)
                                          .Include(vehicle => vehicle.Model)
                                           .ThenInclude(model => model.Manufacturer)
                                          .FirstAsync(x => x.Id == 1);
    PrintVehicleOnConsole(vehicle);

    Console.WriteLine("Done");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.ReadKey();
}


async Task AddFirstVehicleToDB()
{
    ManufacturerEntity manufacturer = new ManufacturerEntity
    {
        Name = "MAZDA"
    };

    await dbContext.Manufacturers.AddAsync(manufacturer);
    await dbContext.SaveChangesAsync();

    ModelEntity model = new ModelEntity
    {
        Name = "2 DE",
        ManufacturerId = manufacturer.Id
    };

    await dbContext.Models.AddAsync(model);
    await dbContext.SaveChangesAsync();

    VehicleEntity vehicle = new VehicleEntity
    {
        ChassisNumber = "ASDFG765R4EGY76T5",
        ColorId = 1,
        EngineNumber = "ZJ",
        LicencePlate = "AAFR678",
        ModelId = 1,
        NumberOfDoors = 5,
        Power = 86,
        Weight = 990
    };

    await dbContext.Vehicles.AddAsync(vehicle);
    await dbContext.SaveChangesAsync();
}

async Task AddSecondVehicleToDB()
{
    VehicleEntity vehicle = new VehicleEntity
    {
        ChassisNumber = "AAAAAAAAAAAAAAAA1",
        EngineNumber = "ZJ",
        LicencePlate = "DESW587",
        NumberOfDoors = 5,
        Power = 150,
        Weight = 1780,
        Color = new ColorEntity
        {
            Name = "Red",
            Code = "ff0000"
        },
        Model = new ModelEntity
        {
            Name = "Civic 2.2",
            Manufacturer = new ManufacturerEntity
            {
                Name = "Honda"
            }
        }
    };

    await dbContext.Vehicles.AddAsync(vehicle);
    await dbContext.SaveChangesAsync();
}

void PrintVehiclesOnConsole(ICollection<VehicleEntity> vehicles)
{
    foreach (var vehicle in vehicles)
    {
        PrintVehicleOnConsole(vehicle);
    }
}

void PrintVehicleOnConsole(VehicleEntity vehicle)
{
    Console.WriteLine(
        $"{vehicle?.LicencePlate} " +
        $"{vehicle?.Model?.Manufacturer?.Name} " +
        $"{vehicle?.Model?.Name} " +
        $"({vehicle?.Color?.Name})"
    );
}