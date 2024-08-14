namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string Modelo, string Imei, int Memoria)
            : base(numero, Modelo, Imei, Memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia");
        }
    }
}