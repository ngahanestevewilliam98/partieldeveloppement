using System;

namespace partieldev.Models
{
    public class Video
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public string Language { get; set; }
        public string Duration { get; set; }
        public string Note { get; set; }
        public string Price { get; set; }
        public string PlayingDate { get; set; }
    }
}
