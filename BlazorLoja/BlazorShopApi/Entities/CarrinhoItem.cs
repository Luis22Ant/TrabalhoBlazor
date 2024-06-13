namespace BlazorShopApi.Entities
{
    public class CarrinhoItem
    {
        public int Id { get; set; }
        public int CarrinhoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidadae { get; set; }

        public Carrinho? Carrinho { get; set; }
        public Produto? Produto { get; set; }
    }
}
