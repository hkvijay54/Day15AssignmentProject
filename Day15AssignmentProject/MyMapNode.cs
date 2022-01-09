using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15AssignmentProject
{
    public class MyMapNode<K,V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValuePair<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValuePair<K,V>>[size];
        }

        protected int GetArrayPostion(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = GetArrayPostion(key);
            LinkedList<KeyValuePair<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValuePair<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPostion(key);
            LinkedList<KeyValuePair<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = GetArrayPostion(key);
            LinkedList<KeyValuePair<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K,V> foundItem = default(KeyValue<K,V>);
            foreach(KeyValue<K, V> item in linkedList)
            {
                if(item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        protected LinkedList<KeyValuePair<K,V>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<K,V>> linkedlist = items[position];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValuePair<K,V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }
        
    }

    public struct KeyValue<k,v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }
}
