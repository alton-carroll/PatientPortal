using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PatientPortal.Data;
using PatientPortal.Models;

namespace PatientPortal.Controllers
{
    public class ReferralsController : Controller
    {
        private readonly PatientPortalContext _context;

        public ReferralsController(PatientPortalContext context)
        {
            _context = context;
        }

        // GET: Referrals
        public async Task<IActionResult> Index()
        {
            var patientPortalContext = _context.Referral.Include(r => r.Patient);
            return View(await patientPortalContext.ToListAsync());
        }

        // GET: Referrals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referral = await _context.Referral
                .Include(r => r.Patient)
                .FirstOrDefaultAsync(m => m.ReferralId == id);
            if (referral == null)
            {
                return NotFound();
            }

            return View(referral);
        }

        // GET: Referrals/Create
        public IActionResult Create()
        {
            ViewData["PatientId"] = new SelectList(_context.Patient, "PatientId", "PatientId");
            return View();
        }

        // POST: Referrals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReferralId,ReferralDate,Doctor,ReferralDoctor,Procedure,Location,CreatedBy,Created,EditedBy,Modified,PatientId")] Referral referral)
        {
            if (ModelState.IsValid)
            {
                _context.Add(referral);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PatientId"] = new SelectList(_context.Patient, "PatientId", "PatientId", referral.PatientId);
            return View(referral);
        }

        // GET: Referrals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referral = await _context.Referral.FindAsync(id);
            if (referral == null)
            {
                return NotFound();
            }
            ViewData["PatientId"] = new SelectList(_context.Patient, "PatientId", "PatientId", referral.PatientId);
            return View(referral);
        }

        // POST: Referrals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReferralId,ReferralDate,Doctor,ReferralDoctor,Procedure,Location,CreatedBy,Created,EditedBy,Modified,PatientId")] Referral referral)
        {
            if (id != referral.ReferralId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(referral);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferralExists(referral.ReferralId))
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
            ViewData["PatientId"] = new SelectList(_context.Patient, "PatientId", "PatientId", referral.PatientId);
            return View(referral);
        }

        // GET: Referrals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referral = await _context.Referral
                .Include(r => r.Patient)
                .FirstOrDefaultAsync(m => m.ReferralId == id);
            if (referral == null)
            {
                return NotFound();
            }

            return View(referral);
        }

        // POST: Referrals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var referral = await _context.Referral.FindAsync(id);
            _context.Referral.Remove(referral);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReferralExists(int id)
        {
            return _context.Referral.Any(e => e.ReferralId == id);
        }
    }
}
