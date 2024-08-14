using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("(00) 0 0000-0000", "Nokia 3310", Guid.NewGuid().ToString(), 64);

            Iphone iphone = new Iphone("(00) 0 0000-0000", "Iphone 13", Guid.NewGuid().ToString(), 256);

            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Facebook");
            nokia.Ligar();

            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
            iphone.Ligar();
        }
    }
}