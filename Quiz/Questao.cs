namespace Quiz
{
    public class Questao
    {
        public Questao(string pergunta, string respostaCerta, List<string> respostasErradas)
        {
            Pergunta = pergunta;
            RespostaCerta = respostaCerta;
            RespostasErradas = respostasErradas;
        }

        public string Pergunta { get; set; }
        public string RespostaCerta { get; set; }
        public List<string> RespostasErradas { get; set; }
    }
}
