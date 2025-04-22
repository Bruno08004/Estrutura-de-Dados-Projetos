class Documento
{
    public string Nome { get; set; }
    public int Paginas { get; set; }

    public override string ToString()
    {
        return $"Documento: {Nome}, Páginas: {Paginas}";
    }
}