using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("144 Main St", "Ghana", "Accra", 82340);
        Address address2 = new Address("456 New Gbawe", "Ghana", "Accra", 43450);

        DateTime lectureDate = DateTime.Now;
        TimeSpan lectureTime = new TimeSpan(14, 0, 0);

        Lecture lecture = new Lecture("Lessons learned from Romeo and Juliet", "What insights can be learned from this famous romantic story", lectureDate, lectureTime, address1, "Dr. Henry Christensen", 100);

        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        DateTime receptionDate = DateTime.Now.AddDays(10);
        TimeSpan receptionTime = new TimeSpan(18, 30, 0);

        Reception reception = new Reception("Company Annual Awards night", "Join us to celebrate our amazing workers", receptionDate, receptionTime, address2, "johndoe@gmail.com");

        Console.WriteLine("Reception Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        DateTime outdoorGatheringDate = DateTime.Now.AddDays(14);
        TimeSpan outdoorGatheringTime = new TimeSpan(11, 0, 0);

        OutdoorGathering outdoorGathering = new OutdoorGathering("Church Picnic", "Enjoy a fun-filled picnic with members of the ward", outdoorGatheringDate, outdoorGatheringTime, address1, "Sunny");

        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}