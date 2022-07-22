using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class GenericMinHeap<T> where T : IComparable
    {
            private List<T> heapList = new List<T>();

            public int GetSize()
            {
                return heapList.Count;
            }

            public T GetMinimum()
            {
                return this.heapList.Count > 0 ? this.heapList[0] : default(T);
            }

            public void InsertToMinHeap(T item)
            {
                heapList.Add(item);
                this.HeapifyUp(heapList.Count - 1);
            }

            public T PopMin()
            {
                if (heapList.Count > 0)
                {
                    T item = heapList[0];
                    heapList[0] = heapList[heapList.Count - 1];
                    heapList.RemoveAt(heapList.Count - 1);

                    this.HeapifyDown(0);
                    return item;
                }

                throw new InvalidOperationException("no element in heap");
            }

            private void HeapifyUp(int index)
            {
                var parent = this.GetParent(index);
                if (parent >= 0 && heapList[index].CompareTo(heapList[parent]) < 0)
                {
                    var temp = heapList[index];
                    heapList[index] = heapList[parent];
                    heapList[parent] = temp;

                    this.HeapifyUp(parent);
                }
            }

            private void HeapifyDown(int index)
            {
                var smallest = index;

                var left = this.GetLeft(index);
                var right = this.GetRight(index);

                if (left < this.GetSize() && heapList[left].CompareTo(heapList[index]) < 0)
                {
                    smallest = left;
                }

                if (right < this.GetSize() && heapList[right].CompareTo(heapList[smallest]) < 0)
                {
                    smallest = right;
                }

                if (smallest != index)
                {
                    var temp = heapList[index];
                    heapList[index] = heapList[smallest];
                    heapList[smallest] = temp;

                    this.HeapifyDown(smallest);
                }

            }

            private int GetParent(int index)
            {
                if (index <= 0)
                {
                    return -1;
                }

                return (index - 1) / 2;
            }

            private int GetLeft(int index)
            {
                return 2 * index + 1;
            }

            private int GetRight(int index)
            {
                return 2 * index + 2;
            }
        }
    }

