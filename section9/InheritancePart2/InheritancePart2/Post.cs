using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePart2
{
    internal class Post
    {


        private static int currentPostId;


        // properties

        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SentUser { get; set; }
        protected bool IsPublic { get; set; }



        // Default constructor. If a derived class does not invoke a base-class 
        // constructor explicitly, the default constructor is called implicitly

        public Post()
        {
            Id = 0;
            Title = "Demo Post";
            IsPublic = true;
            SentUser = "Alex";
        }

        // instance construtor
        public Post(string title, bool isPublic, string sentUser)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SentUser = sentUser;
        }

        protected int GetNextId() // children can also access protected things
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // virtual method override of the ToString method inherited from System.Object
        public override string ToString()
        {
            return String.Format($"{Id} - {Title} - by {SentUser}");
        }

    }
}
