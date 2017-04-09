using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Contracts_Module_Sample.Models;

namespace Contracts_Module_Sample.Controllers
{
    public class TasksController : Controller
    {
        private readonly Contracts_Module_SampleContext _context;

        public TasksController(Contracts_Module_SampleContext context)
        {
            _context = context;    
        }

        // GET: Tasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Task.ToListAsync());
        }

        // GET: Tasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMSTask = await _context.Task
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cMSTask == null)
            {
                return NotFound();
            }

            return View(cMSTask);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Status,CreateDate,EditDate,Description,Deadline")] CMSTask cMSTask)
        {
            if (ModelState.IsValid)
            {
                cMSTask.Initialize();
                _context.Add(cMSTask);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cMSTask);
        }

        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMSTask = await _context.Task.SingleOrDefaultAsync(m => m.ID == id);
            if (cMSTask == null)
            {
                return NotFound();
            }
            return View(cMSTask);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Status,CreateDate,EditDate,Description,Deadline")] CMSTask cMSTask)
        {
            if (id != cMSTask.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cMSTask.Completed();
                    _context.Update(cMSTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CMSTaskExists(cMSTask.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(cMSTask);
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMSTask = await _context.Task
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cMSTask == null)
            {
                return NotFound();
            }

            return View(cMSTask);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cMSTask = await _context.Task.SingleOrDefaultAsync(m => m.ID == id);
            _context.Task.Remove(cMSTask);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CMSTaskExists(int id)
        {
            return _context.Task.Any(e => e.ID == id);
        }

    }
}
