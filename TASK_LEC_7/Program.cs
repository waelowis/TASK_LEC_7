namespace TASK_LEC_7
{
    internal class Program
    {
        class Book
        {
            string title;
            string author;
            string ISBN;
            bool Availability;


            public Book(string title, string author, string iSBN, bool availability = true)
            {
                this.title = title;
                this.author = author;
                ISBN = iSBN;
                Availability = availability;
            }


            public string AllData()
            {
                return $"Book Name : {title}\nauthor : {author}\nISBN : {ISBN}\navailability : {Availability}";
            }
        }

        class Library
        {
            List<Book> books = new List<Book>();



            public bool AddBook(Book book)
            {

                if (book != null)
                {
                    books.Add(book);
                    return true;
                }
                return false;

            }

            public bool RemoveBook(Book book)
            {
                if (book != null)
                {
                    books.Remove(book);
                    return true;
                }
                return false;
            }

            public Book BorrowBook(string Text)
            {
                if (!string.IsNullOrEmpty(Text))
                {

                }


            }


            public Book ReturnBook(string Text)
            {

            }



        }


        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter");

            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter");

            Console.ReadLine();
        }
    }
}

