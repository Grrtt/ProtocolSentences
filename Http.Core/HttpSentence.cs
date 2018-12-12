namespace Http.Core
{
    using System;

    using Get;

    public class HttpSentence
    {
        public static HttpGetConstraint Get()
        {
            return new HttpGetConstraint();
        }
    }
}