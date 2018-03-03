using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public class MyList<T>
    {
        private List<T> _list;

        public MyList()
        {
            _list = new List<T>();
        }

        public MyList(IEnumerable<T> items)
        {
            _list = new List<T>();
            items.ToList().ForEach(item => _list.Add(item));
        }

        public bool All(Func<T, bool> predictate)
        {
            foreach(var item in _list)
            {
                if(!predictate.Invoke(item))
                    return false;
            }
            return true;
        }

        public bool Any(Func<T, bool> predictate)
        {
            foreach(var item in _list)
            {
                if(!predictate.Invoke(item))
                    return true;
            }
            return false;
        }

        #region List methods
        public void Add(T obj) => _list.Add(obj);
        public void Remove(T obj) => _list.Remove(obj);
        #endregion
    }
}