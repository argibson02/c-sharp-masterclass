using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePart2
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        // default fallback to Post default
        public ImagePost() { }

        public ImagePost(string title, string sentUser, string imageURL, bool isPublic)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.SentUser = sentUser;
            this.IsPublic = isPublic;

            // unique to image post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{Id} - {Title} - by {SentUser}. URL: {ImageURL}");
        }
    }
}
