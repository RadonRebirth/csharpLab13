namespace csharpLab13
{
    public interface Publisher
    {
        string BookTitle { get; set; }
        string Author { get; set; }
    }
    public interface IBook : Publisher
    {
        DateTime PublDate { get; set; }
        int PagesCount { get; set; }
    }
    public class Book : IBook
    {
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public DateTime PublDate { get; set; }
        public int PagesCount { get; set; }
    }
    public interface IUser
    {
        string Login { get; set; }
        string Password { get; set; }
    }
    
    public class User : IUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class UserBook : IUser, IBook
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public DateTime PublDate { get; set; }
        public int PagesCount { get; set; }
        public int Price { get; set; }

        public void BuyBook(IUser user,IBook book)
        {
            Console.WriteLine($"Пользователь {user.Login} купил книгу {book.BookTitle} автор: {book.Author}.");
        }
    }
    
     class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book { BookTitle = "4erepashki Ninja", Author = "Splinter", PublDate = new DateTime(1951, 7, 16), PagesCount = 155 };
            Book book2 = new Book { BookTitle = "Mejvremie", Author = "Medina Mirai", PublDate =  DateTime.Parse("23 Ноября, 2020г"), PagesCount = 512 };

            User user1 = new User { Login = "Radon", Password = "uiop" };
            User user2 = new User { Login = "Radinii", Password = "abcde" };

            UserBook userProduct = new UserBook();
            userProduct.BuyBook(user1,book1);
            userProduct.BuyBook(user2, book2);

        }
    }
}