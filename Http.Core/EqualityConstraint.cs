using System;

namespace Http.Core
{
    public class EqualityConstraint<T> where T : new()
    {
        private Func<T, object> func;

        public EqualityConstraint(Func<T, object> func)
        {
            this.func = func;
        }
    }
}