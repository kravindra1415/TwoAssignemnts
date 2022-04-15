// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Output output = new Output();
//output.Start();

output.bankOP();

class Output
{
    public void Start()
    {
        Book book1 = new Book(123, "C#");
        Book book2 = new Book(124, "C");
        Book book3 = new Book(125, "CPP");

        List<Book> books = new List<Book>();

        books.Add(book1);
        books.Add(book2);
        books.Add(book3);

        Library library = new Library(121, "Tech", books);

        List<Book> bks = library.getTotalBooksInLibrary();

        foreach (var Book in bks)
        {
            Console.WriteLine($"The LibId is{library.libraryId} and the name of the Library is {library.libraryName}  and the bookId is{Book.bookId} and the name of the book is {Book.bookName}");

        }
    }

    public void bankOP()
    {
        Console.WriteLine("Enter the Account Number: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your Name: ");
        string a2 = (Console.ReadLine());

        Console.WriteLine("Enter Your Email Id: ");
        string b2 = (Console.ReadLine());

        Console.WriteLine("c2");
        string c2 = (Console.ReadLine());

        Customer c = new Customer(a, a2, b2);

        Console.WriteLine("balance");

        double bal = double.Parse(Console.ReadLine());

        Console.WriteLine("min");

        double min = double.Parse(Console.ReadLine());

        SavingsAccount s1 = new SavingsAccount(a, c, bal, min);

        bool val = s1.withdraw(min);

        if (val == true)
            Console.WriteLine("withdraw successful");
        else
            Console.WriteLine("Failed");

    }
}

