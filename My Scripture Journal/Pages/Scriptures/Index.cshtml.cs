using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal.Data;
using My_Scripture_Journal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace My_Scripture_Journal
{
    public class IndexModel : PageModel
    {
        private readonly My_Scripture_Journal.Data.My_Scripture_JournalContext _context;

        public IndexModel(My_Scripture_Journal.Data.My_Scripture_JournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        //Testing
        [BindProperty(SupportsGet = true)]
        public string SearchString2 { get; set; }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]

        public string ScriptureBook{ get; set; }
        public string BookSort { get; set; }
        public string DateSort { get; set; }
        

            public async Task OnGetAsync(string sortOrder)
        {
            
            BookSort = sortOrder == "Book" ? "name_desc" : "Book";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Scripture> scripturePower = from s in _context.Scripture
                                             select s;
            switch (sortOrder)
            {
                case "book_desc":
                    scripturePower = scripturePower.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scripturePower = scripturePower.OrderBy(s => s.DateAdded);
                    break;
                case "Book":
                    scripturePower = scripturePower.OrderBy(s => s.Book);
                    break;
                case "date_desc":
                    scripturePower = scripturePower.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    scripturePower = scripturePower.OrderBy(s => s.Book);
                    break;
            }
           

            // Use LINQ to get list of books.
            IQueryable<string> bookQuery = from m in _context.Scripture
                                            orderby m.Book
                                            select m.Book;

            var scriptures = from m in _context.Scripture
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureBook);
            }

            //keyword search
            if (!string.IsNullOrEmpty(SearchString2) && string.IsNullOrEmpty(ScriptureBook) && string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(SearchString2));
            }

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            
            if(sortOrder == null)
            {
                Scripture = await scriptures.ToListAsync();
            }
            else
            {
                Scripture = await scripturePower.AsNoTracking().ToListAsync();
            }
           
        }
        
    }
}
