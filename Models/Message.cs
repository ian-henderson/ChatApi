namespace ChatApi.Models;

public class Message
{
    public long? Id { get; set; }
    public string? Content { get; set; }
    public User? Sender { get; set; }
    public User? Receiver { get; set; }
}
