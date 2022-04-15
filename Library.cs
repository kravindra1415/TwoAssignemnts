// See https://aka.ms/new-console-template for more information


class Library
{
    public int libraryId;
    public string libraryName;

    public List<Book> books;

    public Library(int libraryId, string libraryName, List<Book> books)
    {
        this.libraryId = libraryId;
        this.libraryName = libraryName;
        this.books = books;
    }

    public List<Book> getTotalBooksInLibrary()
    {
        return books;
    }

}