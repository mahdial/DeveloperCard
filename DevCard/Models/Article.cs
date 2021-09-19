using System;

namespace DevCard.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Article(int id, string title, string description)
        {
            ID = id;
            Title = title;
            Description = description;
        }
    }
}