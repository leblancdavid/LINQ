using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCollection
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

        public bool All(Func<T, bool> predicate)
        {
            foreach(var item in _list)
            {
                if(!predicate.Invoke(item))
                    return false;
            }
            return true;
        }

        public bool Any(Func<T, bool> predicate)
        {
            foreach(var item in _list)
            {
                if(predicate.Invoke(item))
                    return true;
            }
            return false;
        }

        public MyList<TResult> Select<TResult>(Func<T, TResult> predicate)
        {
            var selectList = new MyList<TResult>();
            foreach(var item in _list)
            {
                selectList.Add(predicate.Invoke(item));
            }
            return selectList;
        }

        #region List methods
        public void Add(T obj) => _list.Add(obj);
        public void Remove(T obj) => _list.Remove(obj);
        public T this[int i]
        {
            get
            {
                return _list[i];
            }
            set
            {
                _list[i] = value;
            }
        }

        public int Count 
        {
            get
            {
                return _list.Count;
            }
        }

        #endregion
    }
}