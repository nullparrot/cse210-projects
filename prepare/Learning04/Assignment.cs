public class Assignment{
    private string _studentName;
    private string _topic;
    public string GetSummary(){
        return "";
    }
}

public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;
    public string GetHomeworkList(){
        return "";
    }
}

public class WritingAssignment : Assignment{
    private string _title;
    public string GetWritingInformation(){
        return "";
    }
}