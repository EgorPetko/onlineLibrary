using Microsoft.EntityFrameworkCore;
using onlineLibrary.BookEntities;

namespace onlineLibrary.Context.ContextManagement
{
    public class BookManagerInContext : IManagerInContext
    {
        private ApplicationContext Context { get; set; }

        private BookEntity Book { get; set; }
        public BookManagerInContext(ApplicationContext context, BookEntity book) 
        {  
            Context = context;
            Book = book;
        }
        public void add()
        {
            Context.Books.Add(Book);
            Context.SaveChanges();
        }
        public void remove()
        {
            Context.Books.Remove(Book);
            Context.SaveChanges();
        }

        public void update()
        {
            Context.Books.Update(Book);
            Context.SaveChanges();
        }
    }
}
