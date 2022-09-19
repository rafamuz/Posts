using Posts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("Wow that´s awesome!");

            Post post1 = new Post(DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I´m going to visit this beautiful country",
                12);

            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Good Night");
            Comment comment4 = new Comment("May the force be with you");

            Post post2 = new Post(DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1.ToString());
            Console.WriteLine(post2.ToString());
            
        }
    }
}

