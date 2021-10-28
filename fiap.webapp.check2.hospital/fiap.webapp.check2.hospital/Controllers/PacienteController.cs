using fiap.webapp.check2.hospital.Models;
using fiap.webapp.check2.hospital.Persistencias;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<Paciente> lista = _context.Pacientes.ToList();
            ViewBag.pacientes = lista;
            return View();
        }
    }
}
