using System.Collections.Generic;
using System.Linq;

namespace Projeto2
{
    public class Principal
    {
        public string Inicial { get; set; }
        public List<RegraDeProducao> RegrasDeProducao { get; set; }
        public List<string> Variaveis { get; set; }
        public List<string> Alfabeto { get; set; }
        public List<int> Sequencia { get; set; }
        public string Resposta { get; set; }
        public string Erro { get; set; }

        public Principal()
        {
            Alfabeto = new List<string>();
            RegrasDeProducao = new List<RegraDeProducao>();
            Variaveis = new List<string>();
            Sequencia = new List<int>();
        }

        public void Validacoes(bool validaSequencia)
        {
            if (string.IsNullOrEmpty(Inicial))
            {
                Erro = "A letra inicial não pode ser vazia.";
                return;
            }

            if (RegrasDeProducao.Count == 0)
            {
                Erro = "Deve existir ao menos uma regra de produção adicionada.";
                return;
            }

            if (Variaveis.Count == 0)
            {
                Erro = "Deve existir ao menos uma variável adicionada.";
                return;
            }
            
            bool Exists = Variaveis.Exists(x => x == Inicial);

            if (!Exists)
            {
                Erro = "Letra inicial não existe nas variáveis adiciondas.";
                return;
            }

            var regras = RegrasDeProducao.Where(x => x.De == string.Empty).ToList();

            if (regras.Count > 0)
            {
                Erro = "Nenhuma regra de produção pode se iniciar com vazio.";
                return;
            }

            if (validaSequencia == true)
            {

                if (Sequencia.Count == 0)
                {
                    Erro = "Deve existir ao menos uma sequência adicionada.";
                    return;
                }

                var regra = RegrasDeProducao.Where(x => x.Indice == Sequencia.FirstOrDefault()).FirstOrDefault();

                if (regra.De != Inicial)
                {
                    Erro = "A primeira regra de produção da sequencia não é compatível com a palavra inicial.";
                    return;
                }
            }

        }

        public string SubstituirPrimeiraOcorrencia(string source, string find, string replace)
        {
            int place = source.IndexOf(find);
            return source.Remove(place, find.Length).Insert(place, replace);
        }

        public List<RegraDeProducao> RecuperarRegrasDeProducaoAPartirDaVariavel(string Variavel)
        {
            var Regras = RegrasDeProducao.Where(x => Variavel.Contains(x.De)).ToList();

            return Regras;
        }

        public void GerarLinguagemAPartirDaSequencia()
        {
            string Resultado = string.Empty;

            for (int i = 0; i < Sequencia.Count; i++)
            {
                if (i == 0)
                {
                    Resultado = Inicial;
                }

                var seq = Sequencia[i];

                var regra = RegrasDeProducao.Where(x => x.Indice == seq).FirstOrDefault();

                Resultado = SubstituirPrimeiraOcorrencia(Resultado, regra.De, regra.Para);

            }

            var LetrasDoResultado = Resultado.ToCharArray().ToList();

            foreach (var LetraResultado in LetrasDoResultado)
            {
                if (!Alfabeto.Contains(LetraResultado.ToString()))
                {
                    Erro = $"O resultado da linguagem gerada não pertence ao alfabeto. Alfabeto: {string.Join(", ", Alfabeto)} | Resultado: {Resultado}";
                    return;
                }

            }

            Resposta = Resultado;
        }

        public List<int> GerarSequenciaAPartirDaLinguagem()
        {
            Graph Grafo = new Graph();
            Queue<Node> Nos = new Queue<Node>();
            Node Node = new Node(Inicial);

            Nos.Enqueue(Node);
            Grafo.AddNode(Node);

            while (Nos.Count > 0)
            {
                Node nodeDequeue = Nos.Dequeue();
                var Regras = RecuperarRegrasDeProducaoAPartirDaVariavel(nodeDequeue.Name);

                foreach (var Regra in Regras)
                {
                    string result = SubstituirPrimeiraOcorrencia(nodeDequeue.Name, Regra.De, Regra.Para);

                    if (result.Length > 8)
                        break;

                    Node = new Node(result);
                    Grafo.AddNode(result);
                    Node.Parent = nodeDequeue;
                    Nos.Enqueue(Node);
                    Grafo.AddEdge(nodeDequeue, Node, Regra.Indice);

                    if (result == "baba")
                    {
                        Node NodeAux = Node;
                        List<Edge> EdgesAux = new List<Edge>();

                        while(NodeAux.Parent != null)
                        {
                            var Parent = NodeAux.Parent;
                            var Edge = Parent.Edges.Where(x => x.To == NodeAux).FirstOrDefault();
                            EdgesAux.Add(Edge);
                            NodeAux = Parent;
                        }

                        EdgesAux.Reverse();

                        return EdgesAux.Select(x => x.Cost).ToList();
                        
                    }
                }
            }

            return null;

        }
    }
}
