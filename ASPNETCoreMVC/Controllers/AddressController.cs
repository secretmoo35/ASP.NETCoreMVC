using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPNETCoreMVC.Data;
using ASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASPNETCoreMVC.Controllers
{
    [Authorize]
    public class AddressController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddressController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Address
        public async Task<IActionResult> Index()
        {
            return View(await _context.Addresses.ToListAsync());
        }

        // GET: Address/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressModel = await _context.Addresses
                .FirstOrDefaultAsync(m => m.ID == id);
            if (addressModel == null)
            {
                return NotFound();
            }

            return View(addressModel);
        }

        // GET: Address/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Detail,District,Subdistrict,Province,Postcode")] AddressModel addressModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addressModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addressModel);
        }

        // GET: Address/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressModel = await _context.Addresses.FindAsync(id);
            if (addressModel == null)
            {
                return NotFound();
            }
            return View(addressModel);
        }

        // POST: Address/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Detail,District,Subdistrict,Province,Postcode")] AddressModel addressModel)
        {
            if (id != addressModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addressModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressModelExists(addressModel.ID))
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
            return View(addressModel);
        }

        // GET: Address/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressModel = await _context.Addresses
                .FirstOrDefaultAsync(m => m.ID == id);
            if (addressModel == null)
            {
                return NotFound();
            }

            return View(addressModel);
        }

        // POST: Address/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addressModel = await _context.Addresses.FindAsync(id);
            _context.Addresses.Remove(addressModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressModelExists(int id)
        {
            return _context.Addresses.Any(e => e.ID == id);
        }
    }
}
