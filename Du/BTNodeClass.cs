using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du
{
    class BTNodeClass
    {
        public class BTNode
        {
            public char data;
            public BTNode lchild;
            public BTNode rchild;
        }

        const int MaxSize = 1000;
        BTNode r = new BTNode();
        public string btstr;
        int counter = 1;

        public BTNodeClass()
        {
            r.lchild = r.rchild = null;
        }

        public void CreateBTNode(string str)
        {
            BTNode[] St = new BTNode[MaxSize];
            BTNode p = null;
            int top = -1, k = 0, j = 0;
            char ch;
            r = null;
            while (j < str.Length)
            {
                ch = str[j];
                switch (ch)
                {
                    case '(': top++; St[top] = p; k = 1; break;
                    case ')': top--; break;
                    case ',': k = 2; break;
                    default:
                        p = new BTNode();
                        p.lchild = p.rchild = null;
                        p.data = ch;
                        if (r == null)
                            r = p;
                        else
                        {
                            switch (k)
                            {
                                case 1: St[top].lchild = p; break;
                                case 2: St[top].rchild = p; break;
                            }
                        }
                        break;
                }
                j++;
            }
        }

        public void CreateBTNode2(string str)
        {
            char[] ch;
            string btstr;
            ch = new char[MaxSize];
            if (str != "")
            {
                btstr = "a" + str;
                ch = btstr.ToCharArray();
            }
            else
                ch = null;
            r = CreateBTNode21(ref r, ch, counter);
        }

        public BTNode CreateBTNode21(ref BTNode t, char[] ch, int counter)
        {
            string str="#";
            char[] cv = str.ToCharArray();
            if (ch == null)
                t = null;
            else
            {
                if (counter < ch.Length)
                {
                    if (ch[counter] == cv[0])
                        t = null;
                    else
                    {
                        t = new BTNode();
                        t.data = ch[counter];
                        t.lchild = t.rchild = null;
                        CreateBTNode21(ref t.lchild, ch, counter * 2);
                        CreateBTNode21(ref t.rchild, ch, counter * 2 + 1);
                    }
                }
            }
            return t;
        }

        public BTNode FindNode(string x)
        {
            char s;
            s = Convert.ToChar(x);
            return FindNode1(r, s);
        }

        private BTNode FindNode1(BTNode t, char s)
        {
            BTNode p;
            if (t == null)
            {
                return null;
            }
            else if (t.data == s)
            {
                return t;
            }
            else
            {
                p = FindNode1(t.lchild, s);
                if (p != null)
                    return p;
                else
                    return FindNode1(t.rchild, s);
            }
        }

        public string DispBTNode()
        {
            btstr = "";
            DispBTNode1(r);
            return btstr;
        }

        private void DispBTNode1(BTNode t)
        {
            if (t != null)
            {
                btstr += t.data.ToString();
                if (t.lchild != null || t.rchild != null)
                {
                    btstr += "(";
                    DispBTNode1(t.lchild);
                    if (t.rchild != null)
                    {
                        btstr += ",";
                    }
                    DispBTNode1(t.rchild);
                    btstr += ")";
                }
            }
        }

        public int BTNodeHeight()
        {
            return BTNodeHeight1(r);
        }

        private int BTNodeHeight1(BTNode t)
        {
            int lchild, rchild;
            if (t == null)
            {
                return 0;
            }
            else
            {
                lchild = BTNodeHeight1(t.lchild);
                rchild = BTNodeHeight1(t.rchild);
                return (lchild > rchild) ? (lchild + 1) : (rchild + 1);
            }
        }

        public int Count()
        {
            return Count1(r);
        }

        public int Count1(BTNode t)
        {
            int n1, n2;
            if (t == null)
                return 0;
            else
            {
                n1 = Count1(t.lchild);
                n2 = Count1(t.rchild);
                return n1 + n2 + 1;
            }
        }

        public int LeafCount()
        {
            return LeafCount1(r);
        }

        private int LeafCount1(BTNode t)
        {
            int n1, n2;
            if (t == null)
                return 0;
            else
            {
                if (t.lchild == null && t.rchild == null)
                    return 1;
                else
                {
                    n1 = LeafCount1(t.lchild);
                    n2 = LeafCount1(t.rchild);
                    return n1 + n2;
                }
            }
        }

        public int Count2()
        {
            return Count21(r);
        }

        public int Count21(BTNode t)
        {
            int i = 0;
            BTNode[] st = new BTNode[MaxSize];
            int top = -1;
            BTNode p;
            top++;
            st[top] = t;
            while (top != -1)
            {
                p = st[top];
                top--;
                i++;
                if (p.rchild != null)
                {
                    top++;
                    st[top] = p.rchild;

                }
                if (p.lchild != null)
                {
                    top++;
                    st[top] = p.lchild;
                }

            }
            return i;

        }

        public string PreOrder()
        {
            return PreOrder1(r);
        }

        private string PreOrder1(BTNode t)
        {
            string mystr = "";
            BTNode[] st = new BTNode[MaxSize];
            int top = -1;
            BTNode p;
            top++; st[top] = t;
            while (top != -1)
            {
                p = st[top]; top--;
                mystr += p.data.ToString() + " ";
                if (p.rchild != null)
                {
                    top++;
                    st[top] = p.rchild;
                }
                if (p.lchild != null)
                {
                    top++;
                    st[top] = p.lchild;
                }
            }
            return mystr;
        }

        public string InOrder()
        {
            btstr = "";
            InOrder1(r);
            return btstr;
        }

        private void InOrder1(BTNode t)
        {
            if (t != null)
            {
                InOrder1(t.lchild);
                btstr += t.data.ToString() + " ";
                InOrder1(t.rchild);
            }
        }

        public string PostOrder()
        {
            btstr = "";
            PostOrder1(r);
            return btstr;
        }

        private void PostOrder1(BTNode t)
        {
            if (t != null)
            {
                PostOrder1(t.lchild);
                PostOrder1(t.rchild);
                btstr += t.data.ToString() + " ";
            }
        }

        public string Path(string str1, string str2)
        {
            int i, j;
            string pstr, apath;
            string qstr, bpath;
            string str = " ";
            string[] path1 = new string[MaxSize];
            string[] path2 = new string[MaxSize];
            BTNode p = FindNode(str1);
            BTNode q = FindNode(str2);
            Path1(p,path1);
            Path2(q,path2);
            pstr = "";
            qstr = "";
            apath = path1[0];
            bpath = path2[0];
            for (i = apath.Length - 1; i > 0; i--)
                pstr += apath[i].ToString() ;
            pstr += apath[i].ToString();
            for (j = bpath.Length - 1; j > 0; j--)
                qstr += bpath[j].ToString() ;
            qstr += bpath[j].ToString();

            str = PathAdd(pstr,qstr);
            
            return str;
        }


        private string PathAdd(string pstr,string qstr)
        {
            int j = 0;
            btstr = "";
            char[] pch = pstr.ToCharArray();
            char[] qch = qstr.ToCharArray();
            for (int i = 0; i < pch.Length / 2; i++)
            {
                char temp;
                temp=pch[i];
                pch[i] = pch[pch.Length - 1 - i];
                pch[pch.Length - 1 - i] = temp;
            }
            char []path= pch.Union(qch).ToArray();        
            for ( j = path.Length - 1; j > 0; j--)
                btstr += path[j].ToString() + "→";
            btstr += path[j].ToString();

            return btstr; ;
        }

        private void Path1(BTNode p,params string []path1)
        {
            Path1(r, p, path1);

        }

        private void Path1(BTNode t, BTNode p, params string[] path1)
        {
            BTNode q;
            int front = -1, rear = -1;
            int n;
            BTNode[] qu = new BTNode[MaxSize];
            int[] parent = new int[MaxSize];
            rear++;
            qu[rear] = t;
            parent[rear] = -1;

            while (front != rear)
            {
                front++;
                q = qu[front];
                if (q == p)
                {
                    n = front;
                    path1[0] = "";
                    while (parent[n] != -1)
                    {
                        path1[0] += qu[n].data.ToString();
                        n = parent[n];
                    }
                    path1[0] += qu[n].data.ToString();
                }
                if (q.lchild != null)
                {
                    rear++;
                    qu[rear] = q.lchild;
                    parent[rear] = front;
                }
                if (q.rchild != null)
                {
                    rear++;
                    qu[rear] = q.rchild;
                    parent[rear] = front;
                }


            }
        }

        private void Path2(BTNode q,params string []path2)
        {
            Path2(r, q, path2);
        }

        private void Path2(BTNode t, BTNode q,params string []path2)
        {

            BTNode p;
            int front = -1, rear = -1;
            int n;
            BTNode[] qu = new BTNode[MaxSize];
            int[] parent = new int[MaxSize];
            rear++;
            qu[rear] = t;
            parent[rear] = -1;

            while (front != rear)
            {
                front++;
                p = qu[front];
                if (p == q)
                {
                    n = front;
                    path2[0] = "";
                    while (parent[n] != -1)
                    {
                        path2[0] += qu[n].data.ToString();
                        n = parent[n];
                    }
                    path2[0] += qu[n].data.ToString();
                }
                if (p.lchild != null)
                {
                    rear++;
                    qu[rear] = p.lchild;
                    parent[rear] = front;
                }
                if (p.rchild != null)
                {
                    rear++;
                    qu[rear] = p.rchild;
                    parent[rear] = front;
                }
            }

        }
    }
}
