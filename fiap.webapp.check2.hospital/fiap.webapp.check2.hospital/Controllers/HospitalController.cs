using fiap.webapp.check2.hospital.Models;
using fiap.webapp.check2.hospital.Persistencias;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return View(_context.Hospitais.Include(h => h.Endereco).ToList());
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Hospital hospital)
        {
            if (ModelState.IsValid)
            {
                _context.Hospitais.Add(hospital);
                _context.SaveChanges();
                TempData["msg"] = "Hospital cadastrado com sucesso";
                return RedirectToAction("index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var hospital = _context.Hospitais.Where(h => h.HospitalId == id).Include(h => h.Endereco).FirstOrDefault();
            return View(hospital);
        }

        [HttpPost]
        public IActionResult Editar(Hospital hospital)
        {
            _context.Hospitais.Update(hospital);
            _context.SaveChanges();
            TempData["msg"] = "Música " + hospital.Nome + " foi alterada";
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var musica = _context.Hospitais.Find(id);
            _context.Hospitais.Remove(musica);
            _context.SaveChanges();
            TempData["msg"] = "Música " + musica.Nome + " foi removida!";
            //Redirect para a listagem
            return RedirectToAction("Index");
        }
    }
}
