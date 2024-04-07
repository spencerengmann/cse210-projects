using System;
class Program
{
    static void Main(string[] args)
        {
            // Create videos
            Video video1 = new Video { Title = "10 Amazing Hacks for Organizing Your Closet", Author = "James Brown", Length = 300 };
            Video video2 = new Video { Title = "Healthy and Delicious Smoothie Recipes", Author = "Alexander Cooper", Length = 400 };
            Video video3 = new Video { Title = "Mindfulness Meditation for Stress Relief", Author = "Bryce Carlson", Length = 500 };
            Video video4 = new Video { Title = "Photography Tips", Author = "Robert Samuel", Length = 250 };

            // Add comments to videos
            video1.Comments.Add(new Comment { Name = "Emma Anderson", Text = "Great video!" });
            video1.Comments.Add(new Comment { Name = "Benjamin Roberts", Text = "I learned a lot." });
            video1.Comments.Add(new Comment { Name = "Ava Mitchell", Text = "Thanks for sharing." });

            video2.Comments.Add(new Comment { Name = "Noah Thompson", Text = "Very informative." });
            video2.Comments.Add(new Comment { Name = "Sophia Campbell", Text = "Well done." });
            video2.Comments.Add(new Comment { Name = "Oliver Johnson", Text = "I'm always on the lookout for nutritious "});

            video3.Comments.Add(new Comment { Name = "Isabella Baker", Text = "Excellent content." });
            video3.Comments.Add(new Comment { Name = "Ethan Reed", Text = "Keep up the good work." });
            video3.Comments.Add(new Comment { Name = "Mia Garcia", Text = "I can't wait for your next video." });

            video4.Comments.Add(new Comment { Name = "Liam Garcia", Text = "Thank you for your expertise" });
            video4.Comments.Add(new Comment { Name = "Lucas Martinez", Text = "These photography tip is a game changer" });
            video4.Comments.Add(new Comment { Name = "harper Wright", Text = "My shots have never looked this breathtaking" });


            // Create list of videos
            List<Video> videos = new List<Video> { video1, video2, video3, video4 };

            // Display information about each video
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"\t{comment.Name}: {comment.Text}");
                }
                Console.WriteLine();
            }
        }
}