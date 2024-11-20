using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_class;

internal class Planet
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int LocatedNumber { get; set; }

    public void infoPlanet()
    {
        string result = $" planet name : {Name}, color : {Color}, located number : {LocatedNumber}";
        Console.WriteLine(result);
    }

}
