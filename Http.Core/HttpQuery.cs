namespace Http.Core
{
    using System;

    public class HttpQuery
    {
        private readonly HttpConstraint constraint;

        public HttpQuery(HttpConstraint constraint)
        {
            this.constraint = constraint;
        }

        public EqualityConstraint<T> Where<T>(Func<T, object> func) where T : new()
        {
            return new EqualityConstraint<T>(func);
        }
    }
}