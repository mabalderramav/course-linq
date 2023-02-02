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
}