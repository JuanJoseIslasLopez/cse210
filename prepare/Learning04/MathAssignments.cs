public class MathAssignments : Assignments
{
    private string _textbookSection;
    private string _problems;

    public MathAssignments(string studentName, string topic, string textbookSection, string problems): base(studentName,topic)
    {   
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}