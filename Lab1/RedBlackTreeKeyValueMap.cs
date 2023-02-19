using System;
using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    //TODO
    public class RedBlackTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        private RedBlackTreeMap<TKey, TValue> redblacktreemap = new RedBlackTreeMap<TKey, TValue>();

        public int Height => redblacktreemap.Height;

        public int Count => redblacktreemap.Count;

        public void Add(TKey key, TValue value)
        {
            redblacktreemap.Add(key, value);
        }

        public void Clear()
        {
            redblacktreemap.Clear();
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
           return new KeyValuePair<TKey, TValue>( key, redblacktreemap[key]);
        }

        public bool Remove(TKey key)
        {
            if(redblacktreemap.ContainsKey(key))
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