namespace papi_prac1_back;

public class Message
{
    public int id { get; set; }
    public string user { get; set; }
    public string text { get; set; }

    public Message(int id, string user, string text)
    {
        this.id = id;
        this.user = user;
        this.text = text;
    }
}

public class MessageDTO
{
    public string user { get; set; }
    public string text { get; set; }
}