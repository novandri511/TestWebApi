namespace membertabel.Model
{
public class TableRequest
{
    public int Id {get; set;}
    public string Username {get; set;}
    public string Password {get; set;}
    public string Email {get; set;}
    public string Full_name {get; set;}
    public string Popularity {get; set;}
}

public class MemberTabel : TableRequest
{
    public int Id {get; set;}
    public string Username {get; set;}
    public string Password {get; set;}
    public string Email {get; set;}
    public string Full_name {get; set;}
    public string Popularity {get; set;}
}

}