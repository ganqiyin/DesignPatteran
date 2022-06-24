using IteratorPattern;

namespace IteratorPattern
{
    public class BookShelfIterator : IIterator
    {
        private BookShelf _bookShelf;

        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = 0;
        }

        public bool hasNext()
        {
            return _index < _bookShelf.getLength();
        }

        public object next()
        {
            Book book=_bookShelf.getBookAt(_index);
            _index++;
            return book;
        }

    }

}

