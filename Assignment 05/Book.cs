using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_05;


internal class Book
{
    private string password = "secret";
    internal int copiesInStock = 5;

    public string? Title;

    public static Genre gener;

}
    internal enum Genre
{
    Fiction,
    NonFiction,
    Science
}
