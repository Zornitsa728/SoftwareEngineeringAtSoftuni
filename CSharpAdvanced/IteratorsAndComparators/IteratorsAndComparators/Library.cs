﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = books.ToList();
        }
        public List<Book> Books { get; set; }
        
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);

            /* foreach (var book in Books)
             * {
             *      yeild return book;
             * } */     
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class LibraryIterator : IEnumerator<Book>
        {
            private int index = -1;

            private List<Book> books;
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
                books.Sort(new BookComparator());
            }
            public Book Current => books[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                index++;

                return index < books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
