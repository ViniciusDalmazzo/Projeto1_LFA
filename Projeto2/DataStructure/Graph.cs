using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    /// <summary>
    /// Classe que representa um grafo.
    /// </summary>
    public class Graph
    {
        /// <summary>
        /// Lista de nós que compõe o grafo
        /// </summary>
        public List<Node> nodes = new List<Node>();
        
        public List<Node> DepthFirstSearch(string begin)
        {
            Stack<Node> pilha = new Stack<Node>();
            List<Node> result = new List<Node>();
            Node nodeBegin = Find(begin);
            nodeBegin.Visited = true;
            pilha.Push(nodeBegin);
            result.Add(nodeBegin);

            while (pilha.Count > 0)
            {
                var nodeAux = pilha.Peek();
                var nodeVizinho = GetNeighbours(nodeAux.Name).Find(n => n.Visited == false);
                if (nodeVizinho != null)
                {
                    nodeVizinho.Parent = nodeAux;
                    pilha.Push(nodeVizinho);
                    result.Add(nodeVizinho);
                    nodeVizinho.Visited = true;
                }
                else
                    pilha.Pop();
            }

            return result;
        }

        /// <summary>
        /// Encontra o nó através do seu nome.
        /// </summary>
        /// <param name="name">O nome do nó.</param>
        /// <returns>O nó encontrado ou nulo caso não encontre nada.</returns>
        private Node Find(string name)
        {
            return nodes.Where(x => x.Name == name).FirstOrDefault();
        }

        /// <summary>
        /// Adiciona um nó ao grafo.
        /// </summary>
        /// <param name="name">O nome do nó a ser adicionado.</param>
        /// <param name="info">A informação a ser armazenada no nó.</param>
        public void AddNode(string name, object info)
        {
            nodes.Add(new Node(name, info));
        }

        /// <summary>
        /// Adiciona um nó ao grafo.
        /// </summary>
        public void AddNode(Node node)
        {
            nodes.Add(node);
        }

        /// <summary>
        /// Adiciona um nó ao grafo.
        /// </summary>
        /// <param name="name">O nome do nó a ser adicionado.</param>
        /// <param name="info">A informação a ser armazenada no nó.</param>
        public void AddNode(string name)
        {
            nodes.Add(new Node(name));
        }

        /// <summary>
        /// Adiciona o arco entre dois nós associando determinado custo.
        /// </summary>
        /// <param name="nameFrom">O nó de origem.</param>
        /// <param name="nameTo">O nó de destino.</param>
        /// <param name="cost">O cust associado.</param>
        public void AddEdge(string nameFrom, string nameTo, int cost)
        {
            Node nodeFrom = Find(nameFrom);
            Node nodeTo = Find(nameTo);

            //if (!nodeTo.EqualsNode(nodeFrom))
            //    nodeTo.AddEdge(nodeFrom, cost);

            nodeFrom.AddEdge(nodeTo, cost);
        }

        /// <summary>
        /// Adiciona o arco entre dois nós associando determinado custo.
        /// </summary>
        /// <param name="nameFrom">O nó de origem.</param>
        /// <param name="nameTo">O nó de destino.</param>
        /// <param name="cost">O cust associado.</param>
        public void AddEdge(Node from, Node to, int cost)
        {
            from.AddEdge(to, cost);
        }

        /// <summary>
        /// Obtem todos os nós vizinhos de determinado nó.
        /// </summary>
        /// <param name="node">O nó origem.</param>
        /// <returns></returns>
        public List<Node> GetNeighbours(string from)
        {
            List<Node> nodes = new List<Node>();

            Node nodeFinded = Find(from);

            foreach (Edge edge in nodeFinded.Edges)
            {
                if (!nodes.Exists(x => x == edge.To))
                    nodes.Add(edge.To);
            }

            return nodes;
        }

    }
}
