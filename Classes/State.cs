namespace Csharp_Deconstructing_Tuples.Classes
{
    public class State<T>
    {
        private T? v;

        public State(T t)
        {
            v = t;
        }

        public State()
        {
        }

        public (Func<T?>, Action<T>) CreateState(T? val)
        {
            v = val;
            return (Get, Set);
        }

        public (Func<T?>, Action<T>) CreateState()
        {
            return (Get, Set);
        }

        private void Set(T t)
        {
            v = t;
        }
        private T? Get()
        {
            return v;
        }
    }
}
