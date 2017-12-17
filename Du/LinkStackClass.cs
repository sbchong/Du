using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du
{
   
    class LinkStackClass
    {
        class LinkStack
        {
            public string data;
            public LinkStack next;
        }

        LinkStack head = new LinkStack();

        public LinkStackClass()
        {
            head.next = null;
        }

        public bool StackEmpty()
        { return (head.next == null); }

        public void Push(string e)
        {
            LinkStack p = new LinkStack();
            p.data = e;
            p.next = head.next;
            head.next = p;
        }

        public bool Pop(ref string e)
        {
            LinkStack p;
            if (head.next == null)
                return false;
            p = head.next;
            e = p.data;
            head.next = p.next;
            p = null;
            return true;
        }

        public bool GetTop(ref string e)
        {
            LinkStack p;
            if (head.next == null)
                return false;
            p = head.next;
            e = p.data;
            return true;
        }

        public string DispLinkStack()
        {
            int i;
            string str = "";
            if (StackEmpty()) str = "";
            else
            {
                LinkStack p = head.next;
                while (p.next != null)
                {
                    str += p.data + ",";
                    p = p.next;
                }
                str += p.data;
            }
            return str;
        }
    }
}
