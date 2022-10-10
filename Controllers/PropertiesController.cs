using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimplePropertyInvesting.Context;
using SimplePropertyInvesting.Models;

namespace SimplePropertyInvesting.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly InvestContext _context;

        public PropertiesController(InvestContext context)
        {
            _context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
              return View(await _context.properties.ToListAsync());
        }

        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.properties == null)
            {
                return NotFound();
            }

            var @property = await _context.properties
                .FirstOrDefaultAsync(m => m.Property_Id == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // GET: Properties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Property_Id,Address1,Address2,Address3,Eircode,Property_Value,Purchase_Price,Purchase_Date,Property_Tax,Property_Insurance,Monthly_Rental_Income,Total_Expenditure,Monthly_Mortgage_Payment,UserID")] Property @property)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@property);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@property);
        }

        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.properties == null)
            {
                return NotFound();
            }

            var @property = await _context.properties.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }
            return View(@property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Property_Id,Address1,Address2,Address3,Eircode,Property_Value,Purchase_Price,Purchase_Date,Property_Tax,Property_Insurance,Monthly_Rental_Income,Total_Expenditure,Monthly_Mortgage_Payment,UserID")] Property @property)
        {
            if (id != @property.Property_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(@property.Property_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@property);
        }

        // GET: Properties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.properties == null)
            {
                return NotFound();
            }

            var @property = await _context.properties
                .FirstOrDefaultAsync(m => m.Property_Id == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // POST: Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.properties == null)
            {
                return Problem("Entity set 'InvestContext.properties'  is null.");
            }
            var @property = await _context.properties.FindAsync(id);
            if (@property != null)
            {
                _context.properties.Remove(@property);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertyExists(int id)
        {
          return _context.properties.Any(e => e.Property_Id == id);
        }
    }
}
