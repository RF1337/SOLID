public class Message
{
    string to, from, body, subject, cc;

    public Message(string to, string from, string body, string subject, string cc)
    {
        this.to = to;
        this.from = from;
        this.body = body;
        this.subject = subject;
        this.cc = cc;
    }

    public string To { get => to; set => to = value; }
    public string From { get => from; set => from = value; }
    public string Body { get => body; set => body = value; }
    public string Subject { get => subject; set => subject = value; }
    public string Cc { get => cc; set => cc = value; }
}

public interface IMessageHandler
{
    void SendMessage(Message m);
    void SendMessageToAll(string[] to, Message m);
}

public class SMTPMessageHandler : IMessageHandler
{
    public void SendMessage(Message m)
    {

    }
    public void SendMessageToAll(string[] to, Message m)
    {

    }
}

public class VMessageHandler : IMessageHandler
{
    public void SendMessage(Message m)
    {

    }
    public void SendMessageToAll(string[] to, Message m)
    {

    }
}

public interface IConverter
{
    string Convert(string message);
}

public class HTMLConverter : IConverter
{
    public string Convert(string message)
    {
        return $"<html><body>{message}<html><body>";
    }
}


