using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System;
using System.Collections.Generic;

namespace Lab3Test
{
    [TestClass]
    public class BookRepositoryTestA
    {
        public BookRepositoryA _bookRepository;

        [TestInitialize]
        public void Initialize()
        {
            Book book1 = new Book(new Guid("c47d497b-6d1e-4780-b4a3-b0ed28b21deb"), "Cum sa nu ai restante",
                12, 5, Genres.NonFiction);
            Book book2 = new Book(new Guid("c47d497b-6d1e-4780-b4a3-b0ed28b21de1"), "Cum sa ai restante",
                13, 6, Genres.Fiction);

            List<Book> lbooks = new List<Book>();
            lbooks.Add(book1);
            lbooks.Add(book2);

            _bookRepository = new BookRepositoryA(lbooks);

        }

        [TestMethod]
        public void RetriveAllBooksTest()
        {
            List<Book> lbooks;
            lbooks = _bookRepository.RetriveAllBooks();
            Assert.IsTrue(lbooks.Count == _bookRepository._books.Count);
        }

        [TestMethod]
        public void RetriveAllOrderByYearDescendingTest()
        {
            List<Book> lbooks;
            lbooks = _bookRepository.RetriveAllOrderByYearDescending();
            _bookRepository._books.Sort((x, y) => x.Year.CompareTo(y.Year));
            _bookRepository._books.Reverse();
            Assert.IsTrue(_bookRepository._books[0].Year == lbooks[0].Year);
        }

        [TestMethod]
        public void RetriveAllOrderByYearAscendingTest()
        {
            List<Book> lbooks;
            lbooks = _bookRepository.RetriveAllOrderByYearAscending();
            _bookRepository._books.Sort((x, y) => x.Year.CompareTo(y.Year));
            Assert.IsTrue(_bookRepository._books[0].Year == lbooks[0].Year);
        }

        [TestMethod]
        public void RetriveAllOrderByPriceAscendingTest()
        {
            List<Book> lbooks;
            lbooks = _bookRepository.RetriveAllOrderByPriceAscending();
            _bookRepository._books.Sort((x, y) => x.Year.CompareTo(y.Year));
            Assert.IsTrue(_bookRepository._books[0].Price == lbooks[0].Price);
        }

        [TestMethod]
        public void RetriveAllOrderByPriceDescendingTest()
        {
            List<Book> lbooks;
            lbooks = _bookRepository.RetriveAllOrderByPriceDescending();
            _bookRepository._books.Sort((x, y) => x.Year.CompareTo(y.Year));
            _bookRepository._books.Reverse();
            Assert.IsTrue(_bookRepository._books[0].Price == lbooks[0].Price);
        }
    }
}
