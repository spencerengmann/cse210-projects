using System;
using System.Threading;

// Base class containing shared attributes and behaviors
public abstract class MeditationPhase
{
    public string PhaseName { get; set; }

    public MeditationPhase(string phaseName)
    {
        PhaseName = phaseName;
    }

    public abstract void ExecutePhase();
}

// Subclass for each phase of the body scan meditation
public class BodyPartPhase : MeditationPhase
{
    private string BodyPart { get; set; }
    private string Sensation { get; set; }

    public BodyPartPhase(string phaseName, string bodyPart, string sensation) : base(phaseName)
    {
        BodyPart = bodyPart;
        Sensation = sensation;
    }

    public override void ExecutePhase()
    {
        Console.WriteLine($"Close your eyes and bring your attention to your {BodyPart.ToLower()}.");
        Console.WriteLine($"Notice any sensations in your {BodyPart.ToLower()}, such as {Sensation.ToLower()}.");
        Thread.Sleep(3000); // Pause for 3 seconds to focus on the body part
    }
}

public class BodyScanMeditation
{
    public void StartBodyScanMeditation()
    {
        Console.WriteLine("Welcome to the Body Scan Meditation!");
        Console.WriteLine("Find a comfortable sitting or lying position.");

        // Define phases using subclasses
        MeditationPhase[] phases = new MeditationPhase[]
        {
            new BodyPartPhase("Toes Phase", "Toes", "warmth or tingling"),
            new BodyPartPhase("Feet Phase", "Feet and heels", "connection between feet and surface beneath"),
            new BodyPartPhase("Lower Legs Phase", "Ankles, calves, and knees", "tension or relaxation"),
            new BodyPartPhase("Upper Legs Phase", "Thighs, hips, and pelvis", "weight of body supported"),
            new BodyPartPhase("Torso Phase", "Lower back, abdomen, and chest", "rise and fall of breath"),
            new BodyPartPhase("Arms Phase", "Shoulders, arms, and hands", "warmth, coolness, or tension"),
            new BodyPartPhase("Neck and Face Phase", "Neck, head, and face", "tightness or relaxation")
        };

        foreach (var phase in phases)
        {
            Console.WriteLine(phase.PhaseName);
            phase.ExecutePhase();
        }

        // Closing phase
        Console.WriteLine("Take a few deep breaths, and when you're ready, slowly open your eyes.");
        Console.WriteLine("Congratulations! You've completed the Body Scan Meditation.");
        Console.WriteLine("Take a moment to reflect on how your body feels after the meditation.");

        Console.ReadLine(); // Wait for user to press Enter before exiting
    }
}
