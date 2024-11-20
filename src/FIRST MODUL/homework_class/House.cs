namespace homework_class;

internal class House
{
    public int Price { get; set; }
    public int Size { get; set; }
    public int YearOfBuild { get; set; }
    public string Location { get; set; }
    public int NumberOfRums { get; set; }

    public void infoHouse()
    {
        string result = $"price : {Price}, size : {Size}, year of build :{YearOfBuild}, location : {Location}, number of rums {NumberOfRums}";
        Console.WriteLine(result);
    }
}
