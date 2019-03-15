using System.Collections.Generic;

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
        public void AddEdge(Node from, Node to, int cost)
        {
            from.AddEdge(to, cost);
        }        
    }
}
