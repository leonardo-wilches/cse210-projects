public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentNamename, string topic, string title) : base(studentNamename, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}