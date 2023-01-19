using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "McDonalds";
        job1._jobTitle = "Burger Flipper";
        job1._startYear = 2008;
        job1._endYear = 2019;
        
        Job job2 = new Job();
        job2._company = "Sandy Lifeguarding";
        job2._jobTitle = "Top Runner";
        job2._startYear = 2019;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Andrew Weist";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}