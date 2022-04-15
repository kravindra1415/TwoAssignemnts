// See https://aka.ms/new-console-template for more information


class Book
{
    public int bookId;
    public string bookName;

    public Book(int bookId, string bookName)
    {
        this.bookId = bookId;
        this.bookName = bookName;
    }

    public void Display()
    {
        Console.WriteLine($"Boook Id is: {bookId} | Book Name is: {bookName}");
    }
}
