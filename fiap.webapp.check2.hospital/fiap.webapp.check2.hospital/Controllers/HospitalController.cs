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
        private EstabContext _context;
        //Construtor que recebe por injeção de dependência o Context
        public HospitalController(EstabContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //Console.WriteLine(_context.Hospital.ToList()[0]);
            return View(_context.Hospital.ToList());
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Hospital hospital)
        {
            _context.Hospital.Add(hospital);
            _context.SaveChanges();
            TempData["msg"] = "Hospital cadastrado com sucesso";
            return RedirectToAction("index");
        }
    }
}
