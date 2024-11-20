namespace homework_class;

internal class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Weight { get; set; }
    public string Type { get; set; }
    public string Live { get; set; }

    public void infoAnimal()
    {
        string result = $" name : {Name}, color : {Color}, weight : {Weight}, type : {Type}, live : {Live} ";
        Console.WriteLine(result);
    }

}
