using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kalkulator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KalkulatorController : Controller
    {

        public double hasil;

        [HttpGet("tambah/{angka_1}/{angka_2}")]
        public double tambah(double angka_1, double angka_2) => hasil = angka_1 + angka_2;

        [HttpPost("tambah/{angka_1}/{angka_2}")]
        public double tambah(double angka_1, double angka_2, double hasil) =>  angka_1 + angka_2;               

        [HttpGet("kurang/{angka_1}/{angka_2}")]
        public double kurang(double angka_1, double angka_2) =>  angka_1 - angka_2;

        [HttpPost("kurang/{angka_1}/{angka_2}")]
        public double kurang(double angka_1, double angka_2, double hasil) => hasil = angka_1 - angka_2;

        [HttpGet("kali/{angka_1}/{angka_2}")]
        public double kali(double angka_1, double angka_2) =>  angka_1 * angka_2;

        [HttpPost("kali/{angka_1}/{angka_2}")]
        public double kali(double angka_1, double angka_2, double hasil) => hasil = angka_1 * angka_2;

        [HttpGet("bagi/{angka_1}/{angka_2}")]
        public double bagi(double angka_1, double angka_2) =>  angka_1 / angka_2;

        [HttpPost("bagi/{angka_1}/{angka_2}")]
        public double bagi(double angka_1, double angka_2, double hasil) => hasil = angka_1 / angka_2;

    }
}