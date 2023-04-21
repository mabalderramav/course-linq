LinqQueries queries = new LinqQueries();

// All books
// PrintValues(queries.AllCollection());

// Books after 2000
// PrintValues(queries.FilterByPublishedDateAfter2000());

// Books with more than 250 pages and contains "In Action" word
// PrintValues(queries.FilterWhitMoreThan250PagesAndContainsInActionWord());

// Books of Python category
// PrintValues(queries.FilterBooksOfPythonCategory());

// Books of Java filter by name and order by ascending
// PrintValues(queries.FilterBooksOfJavaByNameAscending());

// Books with more than 450 pages order by descending
PrintValues(queries.FilterBooksMoreThan450PagesOrderByDescending());

void PrintValues(IEnumerable<Book> bookList)
{
    Console.WriteLine("{0, -60} {1, 15} {2,15}\n", "Title", "Page count", "Published date");
    bookList.ToList().ForEach(book => Console.WriteLine("{0, -60} {1, 15} {2,15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString()));
}
