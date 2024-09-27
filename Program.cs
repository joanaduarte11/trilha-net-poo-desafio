using DesafioPOO.Models;

//Realizados os testes com as classes Nokia e Iphone

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Nokia
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 16);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");
        
        // Criando um objeto Iphone
        Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 64);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}

//SAÍDA: 

// Ligando...
// Instalando o aplicativo WhatsApp no Nokia.
// Recebendo ligação...
// Instalando o aplicativo Instagram no Iphone.
