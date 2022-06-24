using IteratorPattern;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class BookShelf : IAggregate
    {
        private Book[] _books;

        private int _lastIndex = 0;

        public BookShelf(int maxSize)
        {
            _books = new Book[maxSize];
        }

        public Book getBookAt(int index)
        {
            return _books[index];
        }

        public void appendBook(Book book)
        {
            _books[_lastIndex] = book;
            _lastIndex++;
        }

        public int getLength()
        {
            return _lastIndex;
        }

        public IIterator iterator()
        {
            return new BookShelfIterator(this);
        }

    }

}

