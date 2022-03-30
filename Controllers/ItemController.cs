using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using projectPurpleCow;

namespace projectPurpleCow.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        private readonly ItemDBContext _context;

        public ItemController(ItemDBContext context)
        {
            _context = context;
        }

        // get items 
        // GET: api/item
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }

        // get item by id 
        // GET: api/item/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            var item = await _context.Items.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        // updating item
        // PUT: api/item/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Item item)
        {
            if (id != item.id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
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

        // adding new item
        // POST: api/item
        [HttpPost]
        public async Task<ActionResult<Item>> PostItem(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItem", new { id = item.id }, item);
        }

        // adding new items at once 
        // POST: api/items2
        [Route("/items2")]
        [HttpPost]
        public async Task<ContentResult> PostMultipleItems(List<Item> items)
        {
            foreach (Item i in items)
            {
                _context.Items.Add(i);
            }
            await _context.SaveChangesAsync();

            return Content("Items were added to database. Please refer to localhost:3000/items to see changes");
        }

        // delete specific item
        // DELETE: api/item/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // delete items
        // DELETE: api/item/
        [HttpDelete]
        public async Task<IActionResult> DeleteItems()
        {
            if (_context.Items == null)
            {
                return NotFound();
            }

            foreach (Item i in _context.Items) {
                _context.Items.Remove(i);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.id == id);
        }

    }
}
