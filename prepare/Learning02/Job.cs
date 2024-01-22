public class Job{
    public string _jobCompany;
    public string _jobTitle;
    public int _jobStartYear;
    public int _jobEndYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_jobStartYear}-{_jobEndYear}");
    }


}