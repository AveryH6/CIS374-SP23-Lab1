using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    //TODO
    class AVLTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        public AVLTreeMap<TKey, TValue> avlTreeMap = new AVLTreeMap<TKey, TValue>();
          
        public int Height => avlTreeMap.Height;

        public int Count => avlTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            avlTreeMap.Add(key, value);
        }

        public void Clear()
        {
            avlTreeMap.Clear();
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            return new KeyValuePair<TKey, TValue>(key, avlTreeMap[key]);
        }

        public bool Remove(TKey key)
        {
            if (avlTreeMap.ContainsKey(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}