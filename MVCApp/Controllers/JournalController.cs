using Microsoft.AspNetCore.Mvc;
using MVCApp.Services.Interfaces;
using MVCApp.Services.Implementations;
using MVCApp.Models;
using MVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    public class JournalController : Controller
    {
        
        private readonly IJournalService _journalService;
                
        public JournalController(IJournalService journalService)
        {
            _journalService = journalService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_journalService.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Journal model)
        {
            int id = _journalService.Create(model);
            if (id != 0)
                return RedirectToAction("Index");
            return View(model);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_journalService.Get(id));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            bool result = _journalService.Delete(id);
            if (result)
                return RedirectToAction("Index");
            return NotFound();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_journalService.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Journal model)
        {
            int id = _journalService.Edit(model);
            if (id != 0)
                return RedirectToAction("Index");
            return View(model);
        }
       
    }
}
