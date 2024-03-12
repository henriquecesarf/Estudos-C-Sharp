//Screen sound

using System.Diagnostics;

string mensageDeBoasVindas = "Boas vindas ao screen sound";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("***************************");
    Console.WriteLine(mensageDeBoasVindas);
    Console.WriteLine("***************************");
}

void ExibirOpcoesDoMenu()
{
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\nDigite 1 para uma banda");
    Console.WriteLine("Digite 2 para mostar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string selectedOp = Console.ReadLine()!;

    switch (selectedOp)
    {
        case "1":
            RegistrarBanda(); break;
        case "2":
            ListarBandasRegistradas(); break;
        case "3":
            AvaliarUmaBanda(); break;
        case "4":
            MediaDeUmaBanda(); break;
        case "-1":
            Console.WriteLine($"Adeus "); break;
        default:
            Console.WriteLine("Opção não reconhecida"); break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso !");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Listagem das bandas");
    foreach(string item in bandasRegistradas.Keys) { Console.WriteLine($"Banda: {item}"); };
    Console.WriteLine("Aperte qualquer tecla para voltar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a bada {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Aperte qualquer tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MediaDeUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média de uma banda");
    Console.Write("Digite o nome da banda que queria saber da média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = bandasRegistradas[nomeDaBanda]; 
        double media = notas.Average();
        Console.WriteLine($"A média da banda {nomeDaBanda} é {media}");
        Console.WriteLine("Aperte qualquer tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Aperte qualquer tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}






ExibirOpcoesDoMenu();




