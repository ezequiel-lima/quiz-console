namespace Quiz
{
    public class QuizMain
    {
        public QuizMain(string titulo, List<Questao> questoes)
        {
            Titulo = titulo;
            Questoes = questoes;
        }

        public string Titulo { get; set; }
        public List<Questao> Questoes { get; set; }
    }
}
