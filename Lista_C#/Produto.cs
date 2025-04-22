class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Preço: R${Preco:F2}";
    }
}