using System;
namespace DemoLibrary
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Im texting {person.FirstName} to say {message}");
        }
    }
}
