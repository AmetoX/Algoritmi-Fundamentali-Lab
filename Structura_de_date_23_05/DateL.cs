using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structura_de_date_23_05
{
    public class DateL
    {
        int n;
        int _right;
        int _left;
        int[] val;
        int[] T;
        public DateL()
        {
            val = new int[0];
        }
        public void Push(int v) //add an element to stack
        {
            int[] T = new int[val.Length + 1];// 0 1
            for (int i = 0; i < val.Length; i++)
            {               
                T[i + 1] = val[i];
            }
            T[0] = v;
            val = T;
            BubbleSort(val);
        }
        public void Push2(int v) //add an element to stack
        {
            T = new int[val.Length + 1];
            if (v < T[_left]) PushBeg(v);
            else if (v > T[_right]) PushEnd(v);
            else
            {
                for (int i = 0; i <= _right; i++)
                {
                    if (T[i] > v)
                    {
                        InsertAt(i, v);
                    }
                }
            }
            val = T;
        }
        private void PushBeg(int element)
        {
            InsertAt(0, element);
        }
        private void PushEnd(int element)
        {
            n = T.Length;
            T[_right] = element;
            _right = _right++ % n;
        }
        private void InsertAt(int i, int element)
        {
            int temp = T[i];
            T[i] = element;
            for (int k = i + 1; k < _right; k++)
            {
                T[k] = T[k + 1];
            }
            T[_right] = temp;
            _right++;
        }
        public int Pop()
        {
            int toR = val[0];
            int[] T = new int[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++)
            {
                T[i] = val[i + 1];
            }
            val = T;
            return toR;
        }
        public void view()
        {
            for (int i = 0; i < val.Length; i++)
                Console.Write(val[i] + " ");
        }
        public void BubbleSort(int[] arr)
        {
            n = val.Length;
            bool sw;
            for(int i = 0; i < n-1; i++)
            {
                sw = false;
                for(int j = 0; j < n-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        sw = true;
                    }
                }
                if (!sw)
                    break;
            }
        }
    }
}
