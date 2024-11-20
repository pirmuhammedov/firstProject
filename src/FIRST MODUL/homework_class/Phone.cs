namespace homework_class;

internal class Phone
{
    public string Name { get; set; }
    public int Price { get; set; }
    public string Color { get; set; }
    public int MemorySize { get; set; }
    public int BatteryPower { get; set; }

    public void infoPhone()
    {
        string result = $"name : {Name}, price : {Price}, color : {Color}, memory size {MemorySize}, battery power : {BatteryPower}";
        Console.WriteLine(result);
    }
}
