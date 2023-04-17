using System.Text.Json;
public class LinqQueries
{
    private List<Book> bookCollection;
    public LinqQueries()
    {
        bookCollection = new List<Book>();
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            bookCollection = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }

    public IEnumerable<Book> AllCollection()
    {
        return bookCollection;
    }

    public IEnumerable<Book> FilterByPublishedDate(DateTime publishedDate)
    {
        return bookCollection.Where(book => book.PublishedDate == publishedDate);
    }

    public IEnumerable<Book> FilterByPublishedDateRange(DateTime startDate, DateTime endDate)
    {
        return bookCollection.Where(book => book.PublishedDate >= startDate && book.PublishedDate <= endDate);
    }

    public IEnumerable<Book> FilterByPublishedDateAfter2000()
    {
        // Expresion method
        // return bookCollection.Where(book => book.PublishedDate.Year > 2000);

        // Query method
        return from book in bookCollection
               where book.PublishedDate.Year > 2000
               select book;
    }

    public IEnumerable<Book> FilterWhitMoreThan250PagesAndContainsInActionWord()
    {
        // Expresion method
        // return bookCollection.Where(book => book.PageCount > 250 && book.Title.Contains("in Action"));

        // Query method
        return from book in bookCollection
               where book.PageCount > 250 && book.Title.Contains("in Action")
               select book;
    }

    public bool allBooksHasStatus()
    {
        return bookCollection.All(book => book.Status != null && book.Status != string.Empty);
    }

    public IEnumerable<Book> FilterBooksOfPythonCategory()
    {
        return bookCollection.Where(book => book.Categories.Contains("Python"));
    }
}