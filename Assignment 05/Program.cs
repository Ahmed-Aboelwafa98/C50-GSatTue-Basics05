using System.Drawing;

namespace Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //            Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            //Book book = new Book
            //Console.WriteLine(Book.password);//This will give an error because the password field is private 
            #endregion
            #region Q02
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ?
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);//it print 5 the compiler can see becouse it is internal 

            #endregion
            #region Q03
            //Add a public string Title; field to Book. Set it and print it from Main.
            //Book book = new Book();
            //book.Title="Ahmed";
            //Console.WriteLine(book.Title);
            #endregion
        }
    }
}

