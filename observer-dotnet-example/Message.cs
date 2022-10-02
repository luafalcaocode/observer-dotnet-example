namespace observer_dotnet_example
{
    public class Message
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Message(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
