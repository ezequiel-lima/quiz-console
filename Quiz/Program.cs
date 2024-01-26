using Quiz;

List<Questao> listaDeQuestoes = new List<Questao>() { 
    new Questao("Quanto é 4 + 4 ?", "8", new List<string> {"4", "6", "10"}),
    new Questao("Quanto é 8 + 8 ?", "16", new List<string> {"15", "18", "17"}),
    new Questao("Quanto é 16 + 2 ?", "18", new List<string> {"14", "17", "19"}),
    new Questao("Quanto é 6 + 6 ?", "12", new List<string> {"13", "11", "10"}),
};

QuizMain quiz = new QuizMain("Titulo De Teste", listaDeQuestoes);
int contador = 0;

Console.WriteLine(quiz.Titulo);

foreach (var item in quiz.Questoes)
{
    Console.WriteLine($"\n{item.Pergunta}");
    Console.WriteLine(item.RespostaCerta);
    foreach (var item2 in item.RespostasErradas)
    {
        Console.WriteLine(item2);
    }

    Console.Write("Digite sua respsota: ");
    string resposta = Console.ReadLine();

    if (resposta.ToLower() == item.RespostaCerta.ToLower())
        contador++;
}

Console.WriteLine($"\nQuantidade de Repostas Corretas: {contador}");