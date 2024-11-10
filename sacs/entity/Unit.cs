using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sacs.entity
{
    public class Unit
    {

        public Unit()
        {
        }
        public Unit(string UnitCode, string UnitName)
    {
        unit_code=UnitCode;
        unit_name=UnitName;
    }

    public string ID { get; set; }

    public string unit_code { set; get; }

    public string unit_name { get; set; }

}
}
