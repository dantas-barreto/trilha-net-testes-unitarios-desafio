using TestesUnitarios.Desafio.Console.Services;

class Program
{
    static void Main(string[] args)
    {
        ValidacoesLista _lista = new ValidacoesLista();
        ValidacoesString _string = new ValidacoesString();

        var lista = new List<int> {-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5};
        var texto = "Lorem Ipsum dolor sit amet, consectetur adipisceng elit. Vestibulum porttitor, augue et lacinia gravida, ante.";


        _lista.MultiplicarNumerosLista(lista, 4);
        Console.WriteLine(lista);
        Console.WriteLine(_lista.ListaContemDeterminadoNumero(lista, 6));
        _lista.RemoverNumerosNegativos(lista);
        Console.WriteLine(lista);
        Console.WriteLine(_lista.RetornarMaiorNumeroLista(lista));
        Console.WriteLine(_lista.RetornarMenorNumeroLista(lista));

        Console.WriteLine(_string.RetornarQuantidadeCaracteres(texto));
        Console.WriteLine(_string.ContemCaractere(texto, "Ipsum"));
        Console.WriteLine(_string.TextoTerminaCom(texto, "ante"));
    }
}