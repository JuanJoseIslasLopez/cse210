using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Microsoft";
        job1._jobStartYear = 2003;
        job1._jobEndYear = 2005;
        

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._jobCompany = "Apple";
        job2._jobStartYear = 2006;
        job2._jobEndYear = 2008;

        Resume resume1 = new Resume();
        resume1._resumeName = "Allison Rose";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();

    }
}