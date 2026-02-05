using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private int Imei { get; set; }
        private int Memoria { get; set; }
        private int Armazenamento { get; set; }

        public Smartphone(string numero, string modelo, int imei, int memoria, int armazenamento)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Armazenamento = armazenamento;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ConfiguracaoCelular()
        {
            Console.WriteLine("\n");

            Console.WriteLine("===================================================\n APRESENTANDO AS CONFIGURAÇÕES DO SEU DISPOSITIVO: \n===================================================");
            Console.WriteLine($" Seu número de celular: {Numero}\n Modelo: {Modelo}\n IMEI: {Imei}\n Memória RAM: {Memoria} GB \n Armazenamento Interno: {Armazenamento} GB");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}