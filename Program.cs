using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telefone Nokia");
            Nokia nokia = new Nokia("123456789", "Nokia", "Nokia 3310", "123456789", 16);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Telefone Iphone");

            Iphone iphone = new Iphone("987654321", "Apple", "iPhone 12", "987654321", 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}