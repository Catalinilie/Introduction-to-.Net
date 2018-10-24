using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab3
{
    public class BookRepository
    {
        public List<Book> _books;

        public BookRepository(List<Book> books2)
        {
            _books = books2;
        }
        public List<Book> RetriveAllBooks()
        {
            return _books;
        }
        public List<Book> RetriveAllOrderByYearDescending()
        {
            return (from b in _books orderby b.Year descending select b).ToList();
        }
        public List<Book> RetriveAllOrderByYearAscending()
        {
            return (from b in _books orderby b.Year ascending select b).ToList();

        }
        public List<Book> RetriveAllOrderByPriceAscending()
        {
            return (from b in _books orderby b.Price ascending select b).ToList();
        }
        public List<Book> RetriveAllOrderByPriceDescending()
        {
            return (from b in _books orderby b.Price descending select b).ToList();
        }
        public IEnumerable<IGrouping<Genres, Book>> RetrieveAllBooksGroupedByGenre()
        {
            var list = (from book in _books
                        group book by book.genres into newGroup
                        orderby newGroup.Key
                        select newGroup);

            return list;
        }
    }
}
