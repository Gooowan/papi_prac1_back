namespace papi_prac1_back;

public class MessageManager
{
    public List<Message> messages = new List<Message>();
    public MessageManager()
    {
        messages.Add(new Message(1, "david", "Hello"));
        messages.Add(new Message(2, "david", "World"));
        messages.Add(new Message(3, "david", "Foo"));
        messages.Add(new Message(4, "david", "Bar"));
        messages.Add(new Message(5, "david", "Baz"));
    }
    public List<Message> GetMessages()
    {
        return messages;
    }
    public Message GetMessage(int id)
    {
        return messages.FirstOrDefault(m => m.id == id);
    }
    public void AddMessage(Message message)
    {
        message.id = messages.Count > 0 ? messages.Max(m => m.id) + 1 : 1;
        messages.Add(message);
    }
}