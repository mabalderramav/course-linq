LinqQueries queries = new LinqQueries();
PrintValues(queries.AllCollection());

void PrintValues(IEnumerable<Book> bookList)
{
    Console.WriteLine("{0, -60} {1, 15} {2,15}\n", "Title", "Page count", "Published date");
    bookList.ToList().ForEach(book => Console.WriteLine("{0, -60} {1, 15} {2,15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString()));
}
