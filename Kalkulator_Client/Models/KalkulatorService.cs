using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kalkulator_Client.Models
{
    public class KalkulatorService
    {
        public string Url { get; set; } = @"http://localhost:60846/";

        public double Penjumlahan(double angka_1, double angka_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"tambah/{angka_1}/{angka_2}").Result;
                double.TryParse(data, out double hasil);
                return hasil;
            }            
        }

        public double Pengurangan(double angka_1, double angka_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"kurang/{angka_1}/{angka_2}").Result;
                double.TryParse(data, out double hasil);
                return hasil;
            }
        }

        public double Perkalian(double angka_1, double angka_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"kali/{angka_1}/{angka_2}").Result;
                double.TryParse(data, out double hasil);
                return hasil;
            }
        }

        public double Pembagian(double angka_1, double angka_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"bagi/{angka_1}/{angka_2}").Result;
                double.TryParse(data, out double hasil);
                return hasil;
            }
        }
    }
}
