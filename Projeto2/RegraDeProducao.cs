namespace Projeto2
{
    public class RegraDeProducao
    {
        public int Indice { get; set; }
        public string De { get; set; }
        public string Para { get; set; }

        public RegraDeProducao(int indice, string de, string para)
        {
            Indice = indice;
            De = de;
            Para = para;
        }
    }
}
