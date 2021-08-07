using System;
using System.Collections.Generic;

namespace sistemaEspecialista
{
    class Suitability
    {
            
    }

    public class Interacao
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }
        public List<Resposta> Respostas { get; set; }
    }

    public class Resposta
    {
        public int Pontos { get; set; }
        public string Texto { get; set; }
        public Interacao ProximaIteracao { get; set; }
    }
}

