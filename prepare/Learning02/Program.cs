using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2021;
        job1._companyName = "Microsoft Corporation";
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Systems Administrator";
        job2._startYear = 2017;
        job2._endYear = 2018;
        job2._companyName = "Apple";
        job2.Display();



        Resume resume1 = new Resume();
        resume1._name = "Ace Snypa";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();

    }
}