using System;

namespace LearningC_.StackOverFlowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfCreation { get; set; } = DateTime.Now;
        public int NumberOfUpVotes { get; set; } = 0;
        public int NumberOfDownVotes { get; set; } = 0;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;   
        }

        public void upVote(){
            NumberOfUpVotes++;
        }

        public void downVote(){
            NumberOfDownVotes++;
        }

        public override string ToString()
        {
            string message = $"{Title}  {Description}  {TimeOfCreation}  {NumberOfUpVotes}  {NumberOfDownVotes}";
            return message;
        }

        // public static void Main(string[] args){
        //     var post = new Post("Find hello world", "A post to show implementation of hello world");
        //     post.downVote();
        //     post.downVote();
        //     post.upVote();
        //     System.Console.WriteLine(post);

        // }
    }
}