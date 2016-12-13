using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CashDrawer.Data;
using CashDrawer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace CashDrawerAPI.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class LedgerController : Controller
    {
        private CashDrawerContext context;

        public LedgerController(CashDrawerContext ctx)
        {
            context = ctx;
        }
        
        // GET /Ledger
        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<object> Ledger = from ledger in context.Ledger select ledger;

            if (Ledger == null)
            {
                return NotFound();
            }

            return Ok(Ledger);

        }

        // GET /Ledger/5
        [HttpGet("{id}", Name = "GetLedger")]
        public IActionResult Get([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Ledger ledger = context.Ledger.Single(m => m.LedgerId == id);

                if (ledger == null)
                {
                    return NotFound();
                }
                
                return Ok(ledger);
            }
            catch (System.InvalidOperationException ex)
            {
                return NotFound();
            }


        }

        // POST /Ledger
        [HttpPost]
        public IActionResult Post([FromBody] Ledger ledger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Ledger.Add(ledger);
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LedgerExists(ledger.LedgerId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetLedger", new { id = ledger.LedgerId }, ledger);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Ledger ledger)
        {
            if (ledger == null || ledger.LedgerId != id)
            {
                return BadRequest();
            }

            context.Entry(ledger).State = EntityState.Modified;
            if (ledger == null)
            {
                return NotFound();
            }
            context.SaveChanges();
            return new NoContentResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Ledger ledger = context.Ledger.Single(m => m.LedgerId == id);
            if (ledger == null)
            {
                return NotFound();
            }

            context.Ledger.Remove(ledger);
            context.SaveChanges();
            return new NoContentResult();
        }

        private bool LedgerExists(int id)
        {
            return context.Ledger.Count(e => e.LedgerId == id) > 0;
        }
    }
}