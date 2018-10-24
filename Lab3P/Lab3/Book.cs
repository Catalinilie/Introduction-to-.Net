using System;

namespace Lab3
{
    public class Book
    {
        public Guid Id { get;private set; }

        public String Title { get; private set; }

        public int Year { get; private set; }

        public int Price { get; private set; }

        public Genres genres { get; private set; }

        public Book(Guid id, String title, int year, int price, Genres g)
        {
            Id = id;
            Title = title;
            Year = year;
            Price = price;
            genres = g;
        }
    }
}
