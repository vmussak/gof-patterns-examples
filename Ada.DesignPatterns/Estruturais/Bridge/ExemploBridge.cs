using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Estruturais.Bridge
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }

    // Implementador concreto para Email
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email enviado: Assunto: {subject}, Corpo: {body}");
        }
    }

    // Implementador concreto para SMS
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"SMS enviado: Assunto: {subject}, Mensagem: {body}");
        }
    }

    // Abstração
    public abstract class Message
    {
        protected IMessageSender messageSender;

        public Message(IMessageSender sender)
        {
            messageSender = sender;
        }

        public abstract void Send(string subject, string body);
    }

    // Abstração refinada para uma mensagem de usuário
    public class UserMessage : Message
    {
        public UserMessage(IMessageSender sender) : base(sender) { }

        public override void Send(string subject, string body)
        {
            Console.WriteLine("Enviando mensagem do usuário...");
            messageSender.SendMessage(subject, body);
        }
    }

    // Abstração refinada para uma mensagem de administrador
    public class AdminMessage : Message
    {
        public AdminMessage(IMessageSender sender) : base(sender) { }

        public override void Send(string subject, string body)
        {
            Console.WriteLine("Enviando mensagem de administração...");
            messageSender.SendMessage(subject, body);
        }
    }
}
