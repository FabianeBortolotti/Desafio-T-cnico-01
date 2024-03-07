using System;
using System.Threading;
class HelloWorld {
    
  static void Main() {
    Console.WriteLine("Olá, caçador!");
    Console.WriteLine("Aqui no caça sem limite, você conhecerá o perfil de Castiel.");
    
    int idade = 40;
    int datalogin = 2008;
    
    float altura = 1.80f;
    double numSeguidores = 1.000;
    
    string bio = "Anjo do senhor.";
    string nome = "Castiel";
    
    Console.ReadLine();
    
    Console.WriteLine("{0}, {1} anos.", nome,idade);
    Console.WriteLine("Entrou em {0}.\n\r", datalogin);

    Thread.Sleep(2000);

    Console.WriteLine("{0:F2} de altura,", altura);
    Console.WriteLine("Encontra-se em Lawrence, Kansas.\n\r");
    
    Thread.Sleep(3000);
    
    float abate = datalogin * idade;
    
    Console.WriteLine("Número de sequidores: {0:F3}", numSeguidores); 
    
    Console.WriteLine("Quantidade de caçadas: {0}", abate);
    char classeA = 'A';
    char classeB = 'B';
    Console.WriteLine("Entre essas caças há mostrons de classe {0} e classe {1}.\n\r", classeA, classeB);
    
    Thread.Sleep(3000);
    
    
    Console.WriteLine("Recado: {0}\n\r", bio);
    
    Console.WriteLine("Há algo que você queira acrescentar?");
    string algoMais = Console.ReadLine();
    Console.WriteLine("E como isso é relevante?");
    string algoMaiscomplemento = Console.ReadLine();
    
    Console.WriteLine("Incrivel! obrigado pela informação e por visitar o perfil.");
  }
}