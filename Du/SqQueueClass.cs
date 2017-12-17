using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du
{
    class SqQueueClass
    {
        const int MaxSize = 100;
        public string[] data;
        public int rear, front;

        public SqQueueClass()
        {
            data = new string [MaxSize];
            front = rear = 0;
        }

        public bool StackEmpty()
        { return (front == rear); }

        public bool enQueue(string e)
        {
            if ((rear + 1) % MaxSize == front)
                return false;
            rear = (rear + 1) % MaxSize;
            data[rear] = e;
            return true;
        }

        public bool deQueue(ref string e)
        {
            if (front == rear)
                return false;
            front = (front + 1) % MaxSize;
            e = data[front];
            return true;
        }

        public string DispQueue()
        {
            int i;
            string mystr = "";
            if (front == rear)
                mystr = "";
            else
            {
                i = (front + 1) % MaxSize;
                while (i != rear)
                {
                    mystr += data[i] + ",";
                    i = (i + 1) % MaxSize;
                }
                mystr += data[rear];
            }
            return mystr;
        }
        public int GetCount()
        {
            return ((rear - front + MaxSize) % MaxSize);
        }
    }
}
