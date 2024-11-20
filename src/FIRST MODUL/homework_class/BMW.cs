using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_class;

internal class BMW
{
    public string Model { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public int Year { get; set; }
    public int Weight { get; set; }
    public double MotoreSize { get; set; }

    public void infoBMW()
    {
        string result = $"model : {Model}, color : {Color}, weight : {Weight}, price : {Price}, motore size : {MotoreSize}, year : {Year} ";
        Console.WriteLine(result);
    }
}
