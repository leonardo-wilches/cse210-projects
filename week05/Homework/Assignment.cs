public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentNamename, string topic)
    {
        _studentName = studentNamename;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }


    public string GetSummary()
    {
        return _studentName + "-" + _topic;
    }
}