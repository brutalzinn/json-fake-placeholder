// See https://aka.ms/new-console-template for more information
using JsonFakePlaceHolderTeste;

var texto = "Olá, mundo [TESTE] . [FRASERICK]";
var criadorJsonFalso = new StringCriadorJson();

var listaExecutors = new List<StringExecutor>()
{
    new StringExecutor("TESTE", Teste),
    new StringExecutor("FRASERICK", AlgoErradoRick),
};

var resultado = criadorJsonFalso.CriarJsonFake(texto, listaExecutors);

Console.WriteLine($"RESULTADO: {resultado}");

string Teste()
{
    return "BOBÃO!";
}

string AlgoErradoRick()
{
    return "Sei não, Rick. Parece que tá funcionando.";
}