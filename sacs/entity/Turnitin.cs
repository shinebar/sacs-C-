using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sacs.entity
{
    public class Turnitin
    {
        public string Turnitin_Id { get; set; }
        public string Turnitin_Number { get; set; }
        public string Turnitin_Result { get; set; }

        public Turnitin(string turnitinId, string turnitinNumber, string turnitinResult) // Removed extra comma
        {
            Turnitin_Id = turnitinId;
            Turnitin_Number = turnitinNumber;
            Turnitin_Result = turnitinResult;
        }
    }
}
