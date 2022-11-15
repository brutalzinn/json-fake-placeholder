using System.Text.RegularExpressions;

namespace JsonFakePlaceHolderTeste
{
    public class StringBusca
    {
        public string PlaceHolder(string texto, StringExecutor stringExecutor, Dictionary<string, string> substituicoes)
        {
            var pattern = @"\[(.*?)\]";
            MatchCollection matches = Regex.Matches(texto, pattern);

            foreach (Match m in matches)
            {
                var chave = m.Groups[1].ToString().ToUpper();

                Console.WriteLine($"Passou aqui {substituicoes.Count()} {chave}");

                if (stringExecutor.Chave.Equals(chave) && substituicoes.ContainsKey(chave) == false)
                {
                    substituicoes.Add(chave, stringExecutor.Metodo.Invoke());
                }

            }

            foreach (var item in substituicoes)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            return Regex.Replace(texto, pattern, match =>
             {
                 string resultado = "";
                 var valorEncontrado = match.Groups[1].ToString().ToUpper();
                 var existeSubstituicao = substituicoes.TryGetValue(valorEncontrado, out resultado);
                 if (existeSubstituicao)
                 {
                     return resultado;
                 }
                 return $"[{valorEncontrado}]";
             });

        }
    }
}
