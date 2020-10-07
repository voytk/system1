using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Content: ");
            string content = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Book(string author, string title, string content)
    {
        Title = title;
        Author = author;
        Content = content;
    }

    public override string ToString()
    {
        return String.Format("Title : {0}\nAuthor : {1}\nPublished : {2}", Title, Author, Content);
    }
}
