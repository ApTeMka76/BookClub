using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub
{
    public class Core
    {
        private static Data.BookClubEntities _context;
        public static Data.BookClubEntities GetContext()
        {
            if (_context == null)
            {
                _context = new Data.BookClubEntities();
            }
            return _context;
        }
    }
}
