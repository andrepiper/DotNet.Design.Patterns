namespace Singleton
{
    public abstract class GenericSingleton<T>
    {
        protected GenericSingleton() 
        {
        }

        private static T instance;
        private static Func<T> act;
        private static readonly object padlock = new object();

        protected static void initializer(Func<T> action) { act = action; }

        protected static T Instance
        {
            get
            {
                lock (padlock)
                {
                    if (GenericSingleton<T>.instance == null) { instance = act(); }
                    return GenericSingleton<T>.instance;
                }
            }
        }
    }
}