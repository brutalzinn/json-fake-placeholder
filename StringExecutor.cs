namespace JsonFakePlaceHolderTeste
{
    public class StringExecutor
    {
        public string Chave { get; private set; }
        public Func<string> Metodo { get; private set; }
        public StringExecutor(string chave, Func<string> metodo)
        {
            Chave = chave;
            Metodo = metodo;
        }
    }
}
