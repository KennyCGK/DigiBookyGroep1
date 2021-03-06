﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digibooky_domain.Authors;

namespace Digibooky_domain.Books
{
    public class Book
    {
        public static int CounterOfBooks = 0;
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string Isbn { get; set; }
        public Author Author => ReturnAuthorForBook();
        public string AuthorId { get; set; }
        public bool BookIsRentable { get; set; }

        public Book()
        {
            Id = CounterOfBooks;
            CounterOfBooks++;
            BookIsRentable = true;
        }

        private Author ReturnAuthorForBook()
        {
            return DBAuthors.AuthorDB.SingleOrDefault(author => author.Id == AuthorId);
        }


        public override bool Equals(object obj)
        {
            var book = obj as Book;
            return book != null &&
                   Id == book.Id &&
                   Isbn == book.Isbn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Isbn);
        }
    }
}
