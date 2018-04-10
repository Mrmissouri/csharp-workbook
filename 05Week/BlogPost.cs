using System;
using System.Text;

public class Program
{
    public static void Main()
    {

        BlogPost blogPost = new BlogPost(
            title: "My first Blog Post.",
            description: "Added text that describes what this article is about",
            created: DateTime.Now
            );

        Console.WriteLine("Do you like this blog post? Please type Yes or No.");
    }
    public string input = Console.ReadLine().ToLower();

}


class BlogPost
{
    // Fields
    private StringBuilder _summary;
    private int _votes;
    private readonly string _input;
    private int _totalVotes;
    private string _title;
    private string _description;

    // Properties
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Created { get; private set; }

    //Constructor
    public BlogPost(string title, string description, DateTime created)
    {
        _votes = 0;
        _summary = new StringBuilder();
        Title = title;
        Description = description;
        Created = created;
        _totalVotes = 0;

    }

    //Methods
    public void Votes()
    {
        if (input == "yes")
        {
            _votes = _totalVotes++;
        }
        else
        {
            _votes = _totalVotes;
        }

    }
}
