using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooklistRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BooklistRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        #region declaration & constructor
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        #endregion

        #region Properties

        public List<Book> Books { get; set; }

        #endregion

        #region Handler Functions
        public async Task OnGet()
        {
            Books = await _db.Books.ToListAsync();
        } 

        #endregion
    }
}