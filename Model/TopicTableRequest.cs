namespace topictable.Model
{
public class TableRequest
{
    public int Id {get; set;}
    public string Content {get; set;}
    public string Title {get; set;}
    public string Member_id {get; set;}
}

public class TopicTable : TableRequest
{
   public int Id {get; set;}
    public string Content {get; set;}
    public string Title {get; set;}
    public string Member_id {get; set;}
}

}