using var dbContext = new ApplicationDbContext();

try
{

    Console.WriteLine("Done");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.ReadKey();
}
