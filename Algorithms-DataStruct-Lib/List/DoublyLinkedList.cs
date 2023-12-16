using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_DataStruct_Lib.Node;

namespace Algorithms_DataStruct_Lib.List
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedNode<T>? Head { get; private set; }
        public DoublyLinkedNode<T>? Tail { get; private set; }

        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedNode<T>(value));
        }

        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedNode<T>(value));
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            //shift head
            Head = Head.Next;

            Count--;

            if (IsEmpty)
            {
                Tail = null;
            }
            else
            {
                Head.Previous = null;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null; //null the last node
                Tail = Tail.Previous; //shift the Tail (now it is former penultimate node)
            }

            Count--;
        }

        private void AddFirst(DoublyLinkedNode<T> node)
        {
            //save off the head
            DoublyLinkedNode<T> temp = Head;

            //point head to node
            Head = node;

            //insert the rest of the list after the head
            Head.Next = temp;

            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                //before: 1(head) <----> 5 <----> 7 ----> null
                //after:  3(head) <----> 1 <----> 5 <----> 7 ----> null

                // update "previous" ref of the former head
                temp.Previous = Head;
            }

            Count++;
        }

        private void AddLast(DoublyLinkedNode<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            Count++;
        }
    }
}
