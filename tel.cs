using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_24_11_2022_d_z_Smartfon_LIST
{
    class tel
    {

        public string? _name { get; set; }
            public int? _year { get; set; }
            public string? _cam { get; set; }
            public string? _prise { get; set; }
        public tel() { }
        public tel(string? name, int? year, string? color, string? prise)
        {
            _name = name;
            _year = year;
            _cam = color;
            _prise = prise;
        }

        public override string ToString()
        {
            return $"\n Телефон: {_name}, камера {_cam}, год выпуска {_year}, цена {_prise}\n";
        }
    }

    }
