namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int imei, int memoria, int armazenamento) : base(numero, modelo, imei, memoria, armazenamento)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\"...");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}