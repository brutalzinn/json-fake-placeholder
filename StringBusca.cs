using System.Text.RegularExpressions;

namespace JsonFakePlaceHolderTeste
{
    public class StringBusca
    {
        public string PlaceHolder(string texto, StringExecutor stringExecutor)
        {
            var pattern = @"\[(.*?)\]";
            MatchCollection matches = Regex.Matches(texto, pattern);
            var substituicoes = new Dictionary<string, string>();
            foreach (Match m in matches)
            {
                var chave = m.Groups[1].ToString().ToUpper();

                if (stringExecutor.Chave.Equals(chave))
                {
                    substituicoes.Add(chave, stringExecutor.Metodo.Invoke());
                }
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
