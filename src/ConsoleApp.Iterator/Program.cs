// See https://aka.ms/new-console-template for more information

using IteratorPattern;

var bookShelf = new BookShelf(4);
bookShelf.appendBook(new Book("希望的田野上"));
bookShelf.appendBook(new Book("青青河边草"));
bookShelf.appendBook(new Book("背影"));
bookShelf.appendBook(new Book("离别的车站"));
var it = bookShelf.iterator();
while (it.hasNext())
{
    var book= (Book)it.next();
    Console.WriteLine(book.getName());
}
Console.ReadLine();
