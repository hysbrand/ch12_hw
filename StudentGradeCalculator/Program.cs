using System;

class GradeCalculator
{
    public string StudentName { get; set; }
    public int[] Grades { get; set; }
    public double CalculateAverage()
    {
        int total = 0;
        foreach (int grade in Grades) {
            total += grade;
        }
        return (double)total / Grades.Length;
    }
    public string GetLetterGrade()
    {
        double average = CalculateAverage();
        if (average >= 90)
            return "A";
        else if (average >= 80)
            return "B";
        else if (average >= 70)
            return "C";
        else if (average >= 60)
            return "D";
        else
            return "F";
    }
    public int GetHighestGrade()
    {
        int highest = Grades[0];
        foreach (int grade in Grades)
        {
            if (grade > highest)
                highest = grade;
        }
        return highest;
    }
    public int GetLowestGrade()
    {
        int lowest = Grades[0];
        foreach (int grade in Grades)
        {
            if (grade  < lowest)
                lowest = grade;
        }
        return lowest;
    }
    public void DisplayGradeReport()
    {
        Console.WriteLine("===== Grade Report =====");
        Console.WriteLine();
        Console.WriteLine("Student: " + StudentName);
        Console.WriteLine();
        Console.Write("All Grades: ");
        foreach (int grade in Grades)
        {
            Console.Write(grade + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Average Grade: " + CalculateAverage().ToString("F2"));
        Console.WriteLine("Letter Grade: " +GetLetterGrade());
        Console.WriteLine("Highest Grade: " + GetHighestGrade());
        Console.WriteLine("Lowest Grade: " + GetLowestGrade());
    }
}
class Program
{
    static void Main()
    {
        GradeCalculator student1 = new GradeCalculator();
        student1.StudentName = "John Smith";
        student1.Grades = new int[] { 85, 90, 78, 92, 88, 76, 95 };
        student1.DisplayGradeReport();
        double average = student1.CalculateAverage();
        int aboveAverage = 0;
        int belowAverage = 0;
        foreach (int grade in student1.Grades)
        {
            if (grade > average)
                aboveAverage++;
            else if (grade < average)
                belowAverage++;
        }
        int range = student1.GetHighestGrade() - student1.GetLowestGrade();
        Console.WriteLine();
        Console.WriteLine("Statistics:");
        Console.WriteLine("Grades Above Average: " + aboveAverage);
        Console.WriteLine("Grades Below Average: " + belowAverage);
        Console.WriteLine("Grade Range: " + range + " points");
        Console.WriteLine();
        Console.WriteLine("------------------------");
        Console.WriteLine();
        GradeCalculator student2 = new GradeCalculator();
        student2.StudentName = "Jane Doe";
        student2.Grades = new int[] { 70, 82, 91, 65, 88 };
        student2.DisplayGradeReport();
        Console.ReadLine();
    }
}