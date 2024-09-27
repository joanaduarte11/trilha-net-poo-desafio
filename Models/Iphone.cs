namespace DesafioPOO.Models
{
    // Herdado da classe "Smartphone"
    //Sobrescrescrito o método "InstalarAplicativo"
       public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
    }
}