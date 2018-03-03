using System.Collections.Generic;

namespace Collection
{
    public class MyList<T>
    {
        private List<T> _list;

        public MyList()
        {
            _list = new List<T>();
        }

        

        #region List methods
        public void Add(T obj) => _list.Add(obj);
        public void Remove(T obj) => _list.Remove(obj);
        #endregion
    }
}