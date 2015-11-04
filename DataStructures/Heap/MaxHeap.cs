using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Heap
{
    public class MaxHeap<T> where T :IComparable<T>{

        private T[] heap;
        private int DEFAULT_HEAP_SIZE = 11;
        private int last_Index;
        public MaxHeap(int size)
        {
            heap = new T[size+1];
            last_Index = 0;
        }
        public MaxHeap(){
            heap = new T[DEFAULT_HEAP_SIZE];
            last_Index = 0;
        }
        public T Peek(){
            if (heap.Length > 0){
                return heap[1];
            }
            return default(T);
        }
        public void Insert(T value){
            int length = heap.Length;
            int newIndex = last_Index++;
            int parentIndex = newIndex / 2;
            while ((newIndex>1)&&value.CompareTo(heap[parentIndex])>0) {
                heap[newIndex] = heap[parentIndex];

                newIndex = parentIndex;
                parentIndex = newIndex / 2;
            }
            heap[newIndex] = value;

        }
        public T delete(T value){
            if(!IsEmpty()){
                T data = heap[1];
                heap[1] = heap[last_Index];
            }
            return default(T);
        }
        public bool IsEmpty(){
            return last_Index > 0;
        }
        public int GetSize(){
            return last_Index;
        }
        public void Clear(){
            
        }
    }
}
