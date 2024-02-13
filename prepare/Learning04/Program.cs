using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assignments1 = new Assignments("Samuel Bennett","Multiplication");
        Console.WriteLine(assignments1.GetSummary());

        MathAssignments mathAssignments2 = new MathAssignments("Roberto Rodriguez","Fractions","Section 7.3","Problems 8-19");
        Console.WriteLine(mathAssignments2.GetSummary());
        Console.WriteLine(mathAssignments2.GetHomeworkList());

        WritingAssignments writingAssignments3 = new WritingAssignments("Mary Waters","European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignments3.GetSummary());
        Console.WriteLine(writingAssignments3.GetWritingInformation());
    }
}