namespace repliestable.Model
{
public class TableRequest
{
    public int Id {get; set;}
    public string Content {get; set;}
    public string Member_id {get; set;}
    public string Topic_id {get; set;}
}

public class RepliesTable : TableRequest
{
   public int Id {get; set;}
    public string Content {get; set;}
    public string Member_id {get; set;}
    public string Topic_id {get; set;}
}

}