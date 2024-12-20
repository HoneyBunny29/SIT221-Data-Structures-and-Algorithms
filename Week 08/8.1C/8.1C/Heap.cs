﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class Heap<K, D> where K : IComparable<K>
    {

        // This is a nested Node class whose purpose is to represent a node of a heap.
        private class Node : IHeapifyable<K, D>
        {
            // The Data field represents a payload.
            public D Data { get; set; }
            // The Key field is used to order elements with regard to the Binary Min (Max) Heap Policy, i.e. the key of the parent node is smaller (larger) than the key of its children.
            public K Key { get; set; }
            // The Position field reflects the location (index) of the node in the array-based internal data structure.
            public int Position { get; set; }

            public Node(K key, D value, int position)
            {
                Data = value;
                Key = key;
                Position = position;
            }

            // This is a ToString() method of the Node class.
            // It prints out a node as a tuple ('key value','payload','index')}.
            public override string ToString()
            {
                return "(" + Key.ToString() + "," + Data.ToString() + "," + Position + ")";
            }
        }

        // ---------------------------------------------------------------------------------
        // Here the description of the methods and attributes of the Heap<K, D> class starts

        public int Count { get; private set; }

        // The data nodes of the Heap<K, D> are stored internally in the List collection. 
        // Note that the element with index 0 is a dummy node.
        // The top-most element of the heap returned to the user via Min() is indexed as 1.
        private List<Node> data = new List<Node>();

        // We refer to a given comparer to order elements in the heap. 
        // Depending on the comparer, we may get either a binary Min-Heap or a binary  Max-Heap. 
        // In the former case, the comparer must order elements in the ascending order of the keys, and does this in the descending order in the latter case.
        private IComparer<K> comparer;

        // We expect the user to specify the comparer via the given argument.
        public Heap(IComparer<K> comparer)
        {
            this.comparer = comparer;

            // We use a default comparer when the user is unable to provide one. 
            // This implies the restriction on type K such as 'where K : IComparable<K>' in the class declaration.
            if (this.comparer == null) this.comparer = Comparer<K>.Default;

            // We simplify the implementation of the Heap<K, D> by creating a dummy node at position 0.
            // This allows to achieve the following property:
            // The children of a node with index i have indices 2*i and 2*i+1 (if they exist).
            data.Add(new Node(default(K), default(D), 0));
        }

        // This method returns the top-most (either a minimum or a maximum) of the heap.
        // It does not delete the element, just returns the node casted to the IHeapifyable<K, D> interface.
        public IHeapifyable<K, D> Min()
        {
            if (Count == 0) throw new InvalidOperationException("The heap is empty.");
            return data[1];
        }

        // Insertion to the Heap<K, D> is based on the private UpHeap() method
        public IHeapifyable<K, D> Insert(K key, D value)
        {
            Count++;
            Node node = new Node(key, value, Count);
            data.Add(node);
            UpHeap(Count);
            return node;
        }

        private void UpHeap(int start)
        {
            int position = start;
            while (position != 1)
            {
                if (comparer.Compare(data[position].Key, data[position / 2].Key) < 0) Swap(position, position / 2);
                position = position / 2;
            }
        }

        // This method swaps two elements in the list representing the heap. 
        // Use it when you need to swap nodes in your solution, e.g. in DownHeap() that you will need to develop.
        private void Swap(int from, int to)
        {
            Node temp = data[from];
            data[from] = data[to];
            data[to] = temp;
            data[to].Position = to;
            data[from].Position = from;
        }

        public void Clear()
        {
            for (int i = 0; i <= Count; i++) data[i].Position = -1;
            data.Clear();
            data.Add(new Node(default(K), default(D), 0));
            Count = 0;
        }

        public override string ToString()
        {
            if (Count == 0) return "[]";
            StringBuilder s = new StringBuilder();
            s.Append("[");
            for (int i = 0; i < Count; i++)
            {
                s.Append(data[i + 1]);
                if (i + 1 < Count) s.Append(",");
            }
            s.Append("]");
            return s.ToString();
        }

        // TODO: Your task is to implement all the remaining methods.
        // Read the instruction carefully, study the code examples from above as they should help you to write the rest of the code.
        public IHeapifyable<K, D> Delete()
        {
            Node current_node = Min() as Node;
            // Swap the first and the last node
            Swap(1, Count);
            // Delete the last node and decrease count
            data.RemoveAt(Count);
            Count--;
            // DownHeap the first node
            DownHeap(1);
            return current_node;
        }

        private void DownHeap(int start)
        {
            int left = start * 2;
            int right = start * 2 + 1;
            if (left <= Count)
            {
                int largest = left;
                if (right <= Count && comparer.Compare(data[largest].Key, data[right].Key) > 0)
                {
                    largest = right;
                }
                if (comparer.Compare(data[start].Key, data[largest].Key) > 0)
                {
                    Swap(start, largest);
                    DownHeap(largest);
                }
            }
        }

        // Builds a minimum binary heap using the specified data according to the bottom-up approach.
        public IHeapifyable<K, D>[] BuildHeap(K[] keys, D[] data)
        {
            if (Count > 0) throw new InvalidOperationException();

            // Add nodes to list
            for (int i = 0; i < keys.Length; i++)
            {
                Count++;
                Node node = new Node(keys[i], data[i], Count);
                this.data.Add(node);
            }

            // Create new array, copy nodes from list to array
            Node[] nodes = new Node[Count];
            nodes = this.data.Skip(1).ToArray();

            // DownHeap on the last parent to the root
            for (int i = Count / 2; i > 0; i--)
            {
                DownHeap(i);
            }

            // Return the array, not the list
            return nodes;
        }

        public void DecreaseKey(IHeapifyable<K, D> element, K new_key)
        {
            Node selected_node = element as Node;
            if (selected_node != data[selected_node.Position]) throw new InvalidOperationException();
            selected_node.Key = new_key;
            UpHeap(selected_node.Position);
        }

        public IHeapifyable<K, D> DeleteElement(IHeapifyable<K, D> element)
        {
            Node selected_node = element as Node;

            // Swap the node's position with the last position,O(1)
            Swap(selected_node.Position, Count);

            // Remove the last element and decrease Count by 1, O(1)
            data.RemoveAt(Count);
            Count--;

            // UpHeap() to maintain the Heap
            UpHeap(selected_node.Position);

            return selected_node;
        }

        public IHeapifyable<K, D> KthMinElement(int k)
        {
            // Save a copy of the original sequence to a temporary sequence (!= refer)
            List<Node> tempData = new List<Node>();
            Node result = data[0];

            foreach (var item in data)
            {
                tempData.Add(item);
            }

            // Worst case scenario: Finding the Kth Min element in N element, where n = k
            // Worst Time Complexity: k(iterations) * (log(n)(Delete costs log(n)) +1(k decreament))= k*log(n) + k
            // O(klogk)
            while (k > 0)
            {
                result = Delete() as Node;
                k--;
            }

            // Load the copy, as the original sequence has been modified
            this.data = tempData;
            this.Count = this.data.Count - 1;
            return result;
        }

    }
}