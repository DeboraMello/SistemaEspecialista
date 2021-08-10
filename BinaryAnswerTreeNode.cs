public class BinaryAnswerTreeNode
{
    public int Id { get; set; }
    public string Pergunta { get; set; }
    public string RespostaOpcaoUm { get; set; }
    public string RespostaOpcaoDois { get; set; }

    public BinaryAnswerTreeNode(int id, string pergunta, string respostaOpcaoUm, string respostaOpcaoDois)
    {
        Id = id;
        Pergunta = pergunta;
        RespostaOpcaoUm = respostaOpcaoUm;
        RespostaOpcaoDois = respostaOpcaoDois;
    }
}
