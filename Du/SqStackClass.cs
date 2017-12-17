using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du
{
    class SqStackClass
    {
        const int MaxSize = 100;
        public string[] data;
        public int top;

        public SqStackClass()
        {
            data = new string[MaxSize];
            top = -1;
        }
        

        public bool StackEmpty()
        { return (top == -1); }

        public bool Push(string x)
        {
            if (top == MaxSize - 1)
                return false;
            top++;
            data[top] = x;
            return true;

        }

        public bool Pop(ref string e)
        {
            if (StackEmpty())
                return false;
            e = data[top];
            top--;
            return true;
        }

        public bool GetTop(ref string e)
        {
            if (StackEmpty())
                return false;
            e = data[top];
            return true;
        }

        public string DispStack()
        {
            int i;
            string mystr = "";
            if (StackEmpty())
                mystr = "";
            else
            {
                for (i = 0; i < top; i++)
                    mystr += data[i] + ",";
                mystr += data[top];
            }
            return mystr;
        }
    }
}
