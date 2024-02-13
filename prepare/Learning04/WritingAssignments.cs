public class WritingAssignments : Assignments
{
    private string _title;

    public WritingAssignments(string studentName, string topic, string title): base(studentName,topic)
    {   
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}