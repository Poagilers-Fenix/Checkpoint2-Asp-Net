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
            var lista = _context.Hospitais.ToList();
            ViewBag.Hospitais = new SelectList(lista, "HospitalId", "Nome");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente)
        {
            if (ModelState.IsValid && paciente.HospitalId != 0)
            {
                _context.Pacientes.Add(paciente);
                _context.SaveChanges();
                TempData["msg"] = "Paciente cadastrado com sucesso";
                return RedirectToAction("Cadastrar");
            }
            else if(paciente.HospitalId == 0)
            {
                TempData["msg"] = "Paciente precisa ter relação com hospital";
                return View();
            }
            TempData["msg"] = "Erro ao realizar cadastro";
            return View();
        }


        public IActionResult Index(string pesquisa)
        {
            var lista = _context.Pacientes.Include(p => p.Endereco).ToList();
            Console.WriteLine(pesquisa);
            if (!string.IsNullOrEmpty(pesquisa))
            {
                var filter = lista.FindAll(p => p.Nome.ToLower().Contains(pesquisa.ToLower()));
                Console.WriteLine(filter);
                ViewBag.nomePaciente = pesquisa;
                return View(filter);
            }
            //List<Paciente> lista = _context.Pacientes.Where(p => p.Nome.ToLower().Contains(pesquisa.ToLower()) || pesquisa == null).Include(h => h.Endereco).ToList();
            ViewBag.pacientes = lista;
            return View(lista);
        }

        [HttpGet("/paciente/CadastrarDoenca/{idPaciente}")]
        public IActionResult CadastrarDoenca(int idPaciente)
        {
            Paciente paciente = _context.Pacientes.Find(idPaciente);
            var lista = _context.Doencas.ToList();
            ViewBag.doencas = new SelectList(lista, "DoencaId", "Nome");
            ViewBag.doencasPorId = _context.PacienteDoencas.Where(p => p.PacienteId == idPaciente).Select(p => p.Doenca).ToList();
            return View(paciente);
        }

        [HttpPost]
        public IActionResult CadastrarDoenca(PacienteDoenca pacienteDoenca)
        {
            try
            {
                _context.PacienteDoencas.Add(pacienteDoenca);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("CadastrarDoenca");
        }
    }
}
