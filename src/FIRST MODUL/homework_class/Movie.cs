using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_class;

internal class Movie
{
    public string Name { get; set; }
    public string Gerne { get; set; }
    public double RunningTime { get; set; }
    public int YearOfProduction { get; set; }

    public void infoMovie()
    {
        string result = $"name : {Name}, gerne : {Gerne}, running time : {RunningTime}, year of protuction : {YearOfProduction}";
        Console.WriteLine(result);
    }
}
