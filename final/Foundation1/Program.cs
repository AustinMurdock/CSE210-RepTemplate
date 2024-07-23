using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();

        Video video1 = new("abcd", "efgh", 12, [
            new Comment("very_smart_commenter_1", "hi"), 
            new Comment("BarackObama", "ok, now, this is epic")
        ]);
        Video video2 = new("Youtoub Rewind 2016", "YouToub", 867, [
            new Comment("Gaorianwr1abcd", "Go to freestuff.com for a chance for a new car!!!! Limited time offer!!!!!"), 
            new Comment("Gaorianwr2abcd", "Go to freestuff.com for a chance for a new car!!!! Limited time offer!!!!!"), 
            new Comment("Gaorianwr3abcd", "Go to freestuff.com for a chance for a new car!!!! Limited time offer!!!!!"), 
            new Comment("Gaorianwr4abcd", "Go to freestuff.com for a chance for a new car!!!! Limited time offer!!!!!"), 
            new Comment("Gaorianwr5abcd", "Go to freestuff.com for a chance for a new car!!!! Limited time offer!!!!!"),
            new Comment("PickleKebabs", "trust the bots they are just very excited to give you a new car")
        ]);
        Video video3 = new("Can I manually delete all of my comments?", "Vsauce", 86, []);
        Video video4 = new("3rd Quarter Profits Annual Report", "Targej", 2867, [
            new Comment("Dragon_Ball_Y", "about 75 cents i think")
        ]);

        List<Video> videos = new([video1, video2, video3, video4]);

        foreach (Video video in videos) {
            Console.WriteLine($"{video.GetTitle()} posted by {video.GetAuthor()}, {video.GetCommentsCount()} comments:");
            foreach (Comment comment in video.GetComments()) {
                Console.WriteLine($"    {comment.GetComment()}");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        // Console.WriteLine("Hello Foundation1 World!");
    }
}