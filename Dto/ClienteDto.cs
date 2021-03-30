namespace ProjFinanceiro.Dto
{
    public class ClienteDto
    {
        #region Propriedades
            public string Id { get; set; }
            public string Nome { get; set; }
            public ContaExternaDto ContaExterna { get; set; }

        #endregion
    }
}