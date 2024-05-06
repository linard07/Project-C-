//screen sound (começo alura c#)

//#maneira antiga (dentro do void aula)
//string estilo = "*************";
//string curso = "Aprendendo c#";
//Console.WriteLine(estilo);
//Console.WriteLine(curso);
//Console.WriteLine(estilo);

using System.Reflection.Metadata;
using System.Xml;

void aula()
{
Console.WriteLine(@"

█▀▀█ █▀▀█ █▀▀█ █▀▀ █▀▀▄ █▀▀▄ █▀▀ █▀▀▄ █▀▀▄ █▀▀█ 　 █▀▀ 
█▄▄█ █░░█ █▄▄▀ █▀▀ █░░█ █░░█ █▀▀ █░░█ █░░█ █░░█ 　 █░░ 
▀░░▀ █▀▀▀ ▀░▀▀ ▀▀▀ ▀░░▀ ▀▀▀░ ▀▀▀ ▀░░▀ ▀▀▀░ ▀▀▀▀ 　 ▀▀▀ ");
//Console.WriteLine(estilo);
//Console.WriteLine(curso);
//Console.WriteLine(estilo);

}
aula();

List<string> ListaDasBandas = new List<string>{"Efemeros", "O grilo"};

void boasVindas()
{
    Console.WriteLine("Seja Muito bem vindo ;)");
}

void opcoes()
{
    aula();
    boasVindas();
    Console.WriteLine("\nDigite 1 para registra banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opçao: ");
    string escolha = Console.ReadLine()!;
    int escolhanum = int.Parse(escolha);
   
   switch(escolhanum)
   {
    case 1: ResgitarBanda();
        break;
    case 2: mostrarBandas();
        break;
    case 3: Console.WriteLine("Voce escolheu a opçao " + escolhanum);
        break;
    case 4: Console.WriteLine("Voce escolheu a opçao " + escolhanum);
        break;
    case -1: Console.WriteLine("Adeus :)");
        break;
    default: Console.WriteLine("Não é uma opçao valida");
        break;
   }
}
void ResgitarBanda()
{
    Console.Clear();
    Console.WriteLine("Rgistro de bandas ");
    Console.WriteLine("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi  resgitrada com sucesso");
    ListaDasBandas.Add(nomeDaBanda);
    Thread.Sleep(2000);
    Console.Clear();
    opcoes();
}

void mostrarBandas()
{
    Console.Clear();
    Console.WriteLine("Aqui estão as bandas registradas: ");
    for (int i = 0; i < ListaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {ListaDasBandas[i]}");
    }
    Console.WriteLine("pressione quaquer coisa para voltar para o menu");
    Console.ReadKey();
    Console.Clear();
    opcoes();
}

opcoes();
