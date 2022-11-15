namespace JsonFakePlaceHolderTeste
{
    public class StringCriadorJson : StringBusca
    {
        public string CriarJsonFake(string json, List<StringExecutor> listaExecutores)
        {
            var jsonFalso = json;

            foreach (var executor in listaExecutores)
            {
                jsonFalso = PlaceHolder(jsonFalso, executor);
            }

            return jsonFalso;
        }
    }
}
