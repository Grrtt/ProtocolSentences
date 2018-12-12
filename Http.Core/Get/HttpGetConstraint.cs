namespace Http.Core.Get
{
    public class HttpGetConstraint : HttpConstraint
    {
        public string Url { get; private set; }

        public HttpQuery From(string url)
        {
            Url = url;
            return new HttpQuery(this);
        }
    }
}