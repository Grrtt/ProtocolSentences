namespace Http.AppRunner
{
    using Core;

    class Program
    {
        static void Main(string[] args)
        {
            HttpSentence.Get().From("").Where<Model>(q => q.Name).IsEqualTo;
        }
    }
}
