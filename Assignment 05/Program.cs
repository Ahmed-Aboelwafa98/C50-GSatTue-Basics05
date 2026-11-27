using System.Drawing;
using static Assignment_05.Book;

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
            #region Q04
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            //assign it Genre.Science, and print it.
            //Book book = new Book();
            //Book.gener = Genre.Science;
            #endregion
            #region Q05
            //Using the Genre enum above, print the underlying int value of
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //Console.WriteLine((int)Genre.Fiction);//0
            //Console.WriteLine((int)Genre.NonFiction);//1
            //Console.WriteLine((int)Genre.Science);//2

            #endregion
            #region Q06
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //Genre g= (Genre)genreNumber;
            //Console.WriteLine(g);
            #endregion
            #region Q07
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            //Genre genre = Genre.Fiction;
            //Console.WriteLine(genre.ToString());//Fiction
            //Console.WriteLine("###################################");
            //Genre genre = Genre.Fiction;
            //string text = genre.ToString();
            //Console.WriteLine(genre.ToString());//Fiction
            #endregion
            #region Q08
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
            //print the result
            //string genreText = "Science";
            //Genre result = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(result);//Science
            //Console.WriteLine((int)result);//2
            #endregion
        }
    }
}

