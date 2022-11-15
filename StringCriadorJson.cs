namespace JsonFakePlaceHolderTeste
{
    public class StringCriadorJson : StringBusca
    {
        public string CriarJsonFake(string json, List<StringExecutor> listaExecutores)
        {
            var jsonFalso = json;
            var substituicoes = new Dictionary<string, string>();

            foreach (var executor in listaExecutores)
            {
                jsonFalso = PlaceHolder(jsonFalso, executor, substituicoes);
            }

            return jsonFalso;
        }
    }
}
