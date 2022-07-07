using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspProj.Data;
using AspProj.Models;

namespace AspProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdDetailsController : ControllerBase
    {
        private readonly AspProjContext _context;

        public ProdDetailsController(AspProjContext context)
        {
            _context = context;
        }

        // GET: api/ProdDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdDetail>>> GetProdDetail()
        {
            return await _context.ProdDetail.ToListAsync();
        }

        // GET: api/ProdDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdDetail>> GetProdDetail(int id)
        {
            var prodDetail = await _context.ProdDetail.FindAsync(id);

            if (prodDetail == null)
            {
                return NotFound();
            }

            return prodDetail;
        }

        // PUT: api/ProdDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdDetail(int id, ProdDetail prodDetail)
        {
            if (id != prodDetail.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(prodDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProdDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProdDetail>> PostProdDetail(ProdDetail prodDetail)
        {
            _context.ProdDetail.Add(prodDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdDetail", new { id = prodDetail.ProductId }, prodDetail);
        }

        // DELETE: api/ProdDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdDetail(int id)
        {
            var prodDetail = await _context.ProdDetail.FindAsync(id);
            if (prodDetail == null)
            {
                return NotFound();
            }

            _context.ProdDetail.Remove(prodDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProdDetailExists(int id)
        {
            return _context.ProdDetail.Any(e => e.ProductId == id);
        }
    }
}
