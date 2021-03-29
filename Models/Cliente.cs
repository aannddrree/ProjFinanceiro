namespace ProjFinanceiro.Models
{
    public class Cliente
    {
        #region Propriedades

            public int Id { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public ContaCorrente ContaCorrente { get; set; }

        #endregion
    }
}