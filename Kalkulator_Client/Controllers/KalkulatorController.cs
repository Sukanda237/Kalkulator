using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kalkulator_Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kalkulator_Client.Controllers
{
    public class KalkulatorController : Controller
    {
        // GET: Kalkulator
        [HttpGet]
        public ActionResult Index()
        {
            KalkulatorModel kl = new KalkulatorModel();
            return View(kl);
        }

        // GET: Kalkulator/Details/5
        [HttpPost]
        public ActionResult Index(KalkulatorModel p, double a, double b)
        {
            if (ModelState.IsValid)
            {
                KalkulatorService kls = new KalkulatorService();
            }
            return View(p);
        }

        // GET: Kalkulator/Create
        [HttpPost]
        public ActionResult Create(KalkulatorModel p, double a, double b)
        {
            if (ModelState.IsValid)
            {
                KalkulatorService kls = new KalkulatorService();
                kls.Penjumlahan(a, b);
                kls.Pengurangan(a, b);
                kls.Perkalian(a, b);
                kls.Pembagian(a, b);

                return RedirectToAction("kalkulator");
            }
            return View(p);
        }

    }
}