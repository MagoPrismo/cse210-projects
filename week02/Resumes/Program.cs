using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Programmer";
        job1._startYear = "2020";
        job1._endYear = "2025";

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Programmer";
        job2._startYear = "2020";
        job2._endYear = "2025";

        Resume person = new Resume();
        person._name = "John";
        person._jobs.Add(job1);
        person._jobs.Add(job2);

        person.DisplayResume();
    }
}