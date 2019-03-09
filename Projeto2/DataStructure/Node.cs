using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    /// <summary>
    /// Classe que representa um nó dentro de um grafo.
    /// </summary>
    public class Node
    {

        #region Propriedades

        /// <summary>
        /// O nome do nó dentro do grafo.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// A informação adicional armazenada no nó.
        /// </summary>
        public object Info { get; set; }
        /// <summary>
        /// Parent associado ao nó
        /// </summary>
        public Node Parent { get; set; }
        /// <summary>
        /// A lista de arcos associada ao nó.
        /// </summary>
        public List<Edge> Edges { get; private set; }
        /// <summary>
        /// Nó visitado
        /// </summary>
        public Boolean Visited { get; set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Cria um novo nó.
        /// </summary>
        public Node()
        {
            this.Edges = new List<Edge>();
        }

        public Node(string name)
        {
            this.Edges = new List<Edge>();
            this.Name = name;
        }

        /// <summary>
        /// Cria um novo nó.
        /// </summary>
        /// <param name="name">O nome do nó.</param>
        /// <param name="info">A informação armazenada no nó.</param>
        public Node(string name, object info) : this()
        {
            this.Name = name;
            this.Info = info;
            this.Visited = false;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Adiciona um arco com nó origem igual ao nó atual, e destino e custo de acordo com os parâmetros.
        /// </summary>
        /// <param name="to">O nó destino.</param>
        public void AddEdge(Node to)
        {
            AddEdge(to, 0);
        }

        /// <summary>
        /// Adiciona um arco com nó origem igual ao nó atual, e destino e custo de acordo com os parâmetros.
        /// </summary>
        /// <param name="to">O nó destino.</param>
        /// <param name="cost">O custo associado ao arco.</param>
        public void AddEdge(Node to, double cost)
        {
            // Grafo não-dirigido
            Edges.Add(new Edge(this, to, cost));
            Edges.Add(new Edge(to, this, cost));
        }

        #endregion

        #region Métodos Sobrescritos

        /// <summary>
        /// Apresenta a visualização do objeto em formato texto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()

        {
            if (this.Info != null)
            {
                return String.Format("{0}({1})", this.Name, this.Info);
            }
            return this.Name;
        }

        #endregion

    }
}
