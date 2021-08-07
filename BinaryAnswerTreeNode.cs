public class BinaryAnswerTreeNode
{
    private string Pergunta { get; set; }
    private string RespostaOpcaoUm { get; set; }
    private string RespostaOpcaoDois { get; set; }

    public BinaryAnswerTreeNode(string pergunta, string respostaOpcaoUm, string respostaOpcaoDois){
        Pergunta = pergunta;
        RespostaOpcaoUm = respostaOpcaoUm;
        RespostaOpcaoDois = respostaOpcaoDois;
    }
}
