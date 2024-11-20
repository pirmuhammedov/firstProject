using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_class;

internal class Book
{
    public string Name { get; set; }
    public int PageCount { get; set; }
    public string About { get; set; }
    public int Price { get; set; }
    public int ProductionYear { get; set; }
    public string Writer { get; set; }

    public void infoBook()
    {
        string result = $"book name : {Name}, pages count : {PageCount}, about : {About}, price{Price}, production of year {ProductionYear}, " +
            $"Writer of book {Writer}";
        Console.WriteLine(result);
    }

}
