using fiap.webapp.check2.hospital.Models;
using fiap.webapp.check2.hospital.Persistencias;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Controllers
{
    public class HospitalController : Controller
    {
        //Atributo para armazenar o context
        private HospitalContext _context;
        //Construtor que recebe por injeção de dependência o Context
        public HospitalController(HospitalContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //Console.WriteLine(_context.Hospital.ToList()[0]);
            return View(_context.Hospitais.ToList());
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Hospital hospital)
        {
            _context.Hospitais.Add(hospital);
            _context.SaveChanges();
            TempData["msg"] = "Hospital cadastrado com sucesso";
            return RedirectToAction("index");
        }
    }
}
