




using sharp_24_11_2022_d_z_Smartfon_LIST;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Reflection.Metadata.BlobBuilder;

tel one = new tel("Xiaomi 12", 2022, "50 Мпикс", "70 000");
tel two = new tel("Xiaomi 12X", 2022, "50 Мпикс", "54 000");
tel three = new tel("Xiaomi 12 Pro", 2022, "50 Мпикс", "55 500");
tel four = new tel("Xiaomi 12 T", 2022, "108 Мпикс", "52 990");
tel five = new tel("Xiaomi 12 T Pro", 2022, "200 Мпикс", "43 990");
tel six = new tel("Xiaomi 12 Lite", 2022, "108 Мпикс", "38 990");
tel seven = new tel("Xiaomi 4x", 2016, "13 Мпикс", "10 000");
tel eight = new tel("Xiaomi 3S", 2016, "10 Мпикс", "13 590");
tel nine = new tel("Simens A50", 2005, "-------", "3 200");
tel ten = new tel("Sony", 2003, "-------", "1 500");

List<tel> list = new List<tel>()
{
    one, two, three, four,
    five, six, seven, eight, nine, ten
    
};
foreach (tel item in list)
{
    Console.WriteLine(item);
}
List<tel> FoundTel = list.FindAll(item => item._year == 2003);

foreach (tel item in FoundTel) 
{
   
    Console.WriteLine("телефоны выпущенные в 2003г {0}",item);
}