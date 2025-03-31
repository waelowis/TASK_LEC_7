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

            public bool Available()
            {
                return Availability;
            }
        }

        class Library
        {
            List<Book> books = new List<Book>();

            public Book Search(string text)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].AllData().ToLower().Contains(text.ToLower()))
                    {
                        return books[i];
                    }
                }
                return null;
            }

            public void AddBook(Book book)
            {
                books.Add(book);
            }



            public bool RemoveBook(string text)
            {

                Book book = Search(text);
                if (book != null && book.Available())
                {
                    books.Remove(book);
                    return true;
                }
                return false;

            }

            public bool BorrowBook(string text)
            {
                Book book = Search(text);
                if (book != null && book.Available())
                {

                    return true;
                }
                return false;

            }


            public bool ReturnBook(string text)
            {

                Book book = Search(text);
                if (book != null && !book.Available())
                {

                    return false;
                }
                return true;

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

