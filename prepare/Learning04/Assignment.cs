
class Assignment
{
    protected string _studentName; 
    /*
        Another thing that you could have done was "string studentName = GetStudentName();" 
        in the WritingAssignment class note made for myself for future reference so I don't
        need to make variables protected. Either way this program worked though but just for 
        future knowledge. Also you don't need to create a constructor for attributes that have
        already been initialized by a data type as seen above with "string".
    */                                   
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;

    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}
