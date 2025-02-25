using Lab4_SOLID.BookManagement;
using Lab4_SOLID.Interface;
using Lab4_SOLID.ReaderManagement;
using Lab4_SOLID.ReportManagement;

List<IBook> books = new List<IBook>
        {
            new Book(1,"The light", "Helen", "C", 10),
            new Book(2,"The dark", "Helen", "C", 20),
            new Book(3,"Let's sing a song", "Helen", "C", 10)
        };

BookService bookService = new BookService(books);

List<IUser> users = new List<IUser>
{
    new Reader(1,"Kim"),
    new Reader(2,"Kab"),
    new Reader(3,"Kang"),
};
ReaderManagement readerManagement = new ReaderManagement(users);

IGenerateReport generateReport = new GenerateReport();

generateReport.Generate(bookService.GetBookByTitle("The light"), new Reader(4, "Hoho"));
