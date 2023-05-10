
class WritingAssignment : Assignment
{
    private string _history;

    public WritingAssignment(string studentName, string topic, string history) : base (studentName, topic)
    {
        _history = history;
    }

    public string GetWritingInformation()
    {
        return $"{_history} by {_studentName}";
    }
   
}