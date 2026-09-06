namespace C_ASS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            object obj = book;

            Console.WriteLine(obj);
        }
    }
}
class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}

