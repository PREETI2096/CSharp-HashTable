﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hashtable
{
    internal class HashTable<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                Data = data;
            }
        }

        private Node[] Names;

        public HashTable(int size)
        {
            Names = new Node[size];
        }

        public void Add(T data)
        {
            Node newNode = new Node(data);
            int arrayIndex = Math.Abs(data.GetHashCode()) % Names.Length;
            Names[arrayIndex] = newNode;
        }
    }
}