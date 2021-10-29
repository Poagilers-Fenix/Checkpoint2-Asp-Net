using fiap.webapp.check2.hospital.Models;
using fiap.webapp.check2.hospital.Persistencias;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Controllers
{
    public class PacienteController : Controller
    {
        private HospitalContext _context;

        public PacienteController(HospitalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Pacientes.Add(paciente);
                _context.SaveChanges();
                TempData["msg"] = "Paciente cadastrado com sucesso";
                return RedirectToAction("Cadastrar");
            }
            return View();
        }


        public IActionResult Index()
        {
            List<Paciente> lista = _context.Pacientes.Include(h => h.Endereco).ToList();
            ViewBag.pacientes = lista;
            return View(lista);
        }

        [HttpGet("/paciente/CadastrarDoencaPraPaciente/{idPaciente}")]
        public IActionResult CadastrarDoencaPraPaciente(int idPaciente)
        {
            Paciente paciente = _context.Pacientes.Find(idPaciente);
            var lista = _context.Doencas.ToList();
            ViewBag.doencas = new SelectList(lista, "DoencaId", "Nome");
            return View(paciente);
        }
    }
}
