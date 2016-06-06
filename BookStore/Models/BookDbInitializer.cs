using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "CHeburashka", Author = "Krokodil Gena", Price = 33 });
            db.Books.Add(new Book { Name = "Chuk i gek", Author = "Phuskin",  Price = 12 });
            db.Books.Add(new Book { Name = "Eoba book", Author = "kolobok",  Price = 55 });

            base.Seed(db);
        }
    }
}