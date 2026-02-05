using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Dispositivo NOKIA");

Smartphone nokia = new Nokia(numero: "(11) 9876-5432", modelo: "NK007", imei: 123410, memoria: 4, armazenamento: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ConfiguracaoCelular();

Console.WriteLine("\n");

Console.WriteLine("Dispositivo IPHONE");

Smartphone iphone = new Iphone(numero: "(11) 91234-5678", modelo: "Iphone 17 Pro Max", imei: 654321, memoria: 12, armazenamento: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.ConfiguracaoCelular();


