using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjektTablica.Data;
using ProjektTablica.Models;
using X.PagedList;

namespace ProjektTablica.Controllers
{
    public class OgloszeniesController : Controller
    {
        private readonly ProjektTablicaContext _context;

        public OgloszeniesController(ProjektTablicaContext context)
        {
            _context = context;
        }

        // GET: Ogloszenies
        public async Task<IActionResult> Index(string searchString, int? page, string currentFilter)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            var ogloszenia = from o in _context.Ogloszenie select o;
            ogloszenia = ogloszenia.Where(o => o.Data > DateTime.Now.AddDays(-10)).OrderByDescending(x => x.Data);
            IPagedList<Ogloszenie> pagedList = new PagedList<Ogloszenie>(ogloszenia, pageNumber, pageSize);
            return View(pagedList);
        }

        // GET: Ogloszenies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ogloszenie = await _context.Ogloszenie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ogloszenie == null)
            {
                return NotFound();
            }

            return View(ogloszenie);
        }

        // GET: Ogloszenies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ogloszenies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tytul,Data,Tresc")] Ogloszenie ogloszenie)
        {
            if (ModelState.IsValid)
            {
                ogloszenie.Data = DateTime.Now;
                _context.Add(ogloszenie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ogloszenie);
        }


        private bool OgloszenieExists(int id)
        {
            return _context.Ogloszenie.Any(e => e.Id == id);
        }
    }
}
