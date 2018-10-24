using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab3
{
    public class BookRepositoryA
    {
        public List<Book> _books;

        public BookRepositoryA(List<Book> books2)
        {
            _books = books2;
        }
        public List<Book> RetriveAllBooks()
        {
            return _books;
        }
        public List<Book> RetriveAllOrderByYearDescending()
        {
            var result = _books.OrderByDescending(b => b.Year);
            return result.ToList();

        }
        public List<Book> RetriveAllOrderByYearAscending()
        {
            var result = _books.OrderBy(b => b.Year);
            return result.ToList();
        }
        public List<Book> RetriveAllOrderByPriceAscending()
        {
            var result = _books.OrderBy(b => b.Price);
            return result.ToList();
        }
        public List<Book> RetriveAllOrderByPriceDescending()
        {
            var result = _books.OrderByDescending(b => b.Price);
            return result.ToList();
        }
        public IEnumerable<IGrouping<Genres, Book>> RetrieveAllBooksGroupedByGenre()
        {
            var result = _books.GroupBy(b => b.genres);
            return result.ToList();
            
        }
    }
}
