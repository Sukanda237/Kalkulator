using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator_Client.Models
{
    public class KalkulatorModel
    {
        public double angka_1 { get; set; }
        public double angka_2 { get; set; }

        public string Operasi { get; set; } = "+";

        public double result
        {
            get
            {
                if (Operasi == "+")
                    return angka_1 + angka_2;
                else if (Operasi == "-")
                    return angka_1 - angka_2;
                else if (Operasi == "*")
                    return angka_1 * angka_2;
                else
                    return angka_1 / angka_2;
            }
        }
    }
}
