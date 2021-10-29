using fiap.webapp.check2.hospital.Models;
using fiap.webapp.check2.hospital.Persistencias;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Controllers
{
    public class DoencaController : Controller
    {

        private HospitalContext _context;

        public DoencaController(HospitalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Doenca doenca)
        {
            if (ModelState.IsValid)
            {
                _context.Doencas.Add(doenca);
                _context.SaveChanges();
                TempData["msg"] = "Doença cadastrada com sucesso";
                return RedirectToAction("Cadastrar");
            }
            return View();
        }
    }
}
