namespace Singleton
{
    public class GenericSingleton<T> : IGenericSingleton<T> where T: class
    {
        private static readonly GenericSingleton<T> _genericSingleton = new GenericSingleton<T>();

        private readonly List<T> _fakeDb;
        private GenericSingleton()
        {
            _fakeDb = new List<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            if (t != null) _fakeDb.Add(t);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<T> List()
        {
            return _fakeDb;
        }

        public GenericSingleton<T> GetInstance() => _genericSingleton;
    }
}