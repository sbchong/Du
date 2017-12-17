using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Du
{
    //------图的邻接矩阵-------------------------------------------------
    struct VertexType					    //顶点类型
    {
        public int no;						//顶点编号
        public string data;				    //顶点其他信息
    };
    struct MGraph                           //图邻接矩阵类型
    {
        public int [,] edges;		        //邻接矩阵的边数组
        public int n,e;					    //顶点数，边数
        public VertexType [] vexs;		    //存放顶点信息
    };
    //-------------------------------------------------------------------

    //------图的邻接表---------------------------------------------------
    class ArcNode					        //边结点类型
    {
        public int adjvex;			        //该边的终点编号
        public ArcNode nextarc;		        //指向下一条边的指针
        public int weight;				    //该边的相关信息,如边的权值
    };
    struct VNode                            //表头结点类型
    {
        public string data;				    //顶点信息
        public ArcNode firstarc;			//指向第一条边
    };
    struct ALGraph                          //图的邻接表类型
    {
        public VNode [] adjlist;			//邻接表数组
        public int n,e;					    //图中顶点数n和边数e
    };						
    //-------------------------------------------------------------------
    class GraphClass
    {
        const int MAXV = 100;               //最大顶点个数
        const int INF = 32767;              //用INF表示∞
        MGraph g = new MGraph();
        ALGraph G = new ALGraph();
        public GraphClass()                 //构造函数
        {
            g.edges = new int[MAXV,MAXV];
            g.vexs = new VertexType[MAXV];
            G.adjlist = new VNode[MAXV];
        }
        //-------图的基本运算算法-----------------
        public void CreateMGraph(int n, int e, int[,] a)  //通过相关数据建立邻接矩阵
        {
            int i, j;
            g.n = n;
            g.e = e;
            for (i = 0; i < g.n; i++)
                for (j = 0; j < g.n; j++)
                    g.edges[i, j] = a[i, j];
        }
        public string DispMGraph()                         //输出图的邻接矩阵
        {
            string mystr = "";
            int i, j;
            for (i = 0; i < g.n; i++)
            {
                for (j = 0; j < g.n; j++)
                    if (g.edges[i, j] == INF)
                        mystr += string.Format("{0,-3}", "∞");
                    else
                        mystr += string.Format("{0,-4}", g.edges[i, j].ToString());
                mystr += "\r\n";
            }
            return mystr;
        }
        public void MatToList()	                            //将邻接矩阵g转换成邻接表G
        {
            int i, j;
            ArcNode p;
            for (i = 0; i < g.n; i++)			                //给邻接表中所有头结点的指针域置初值
                G.adjlist[i].firstarc = null;
            for (i = 0; i < g.n; i++)					        //检查邻接矩阵中每个元素
                for (j = g.n - 1; j >= 0; j--)
                    if (g.edges[i, j] != 0 && g.edges[i, j] != INF)		 //存在一条边
                    {
                        p = new ArcNode();	                    //创建一个结点p
                        p.adjvex = j;
                        p.weight = g.edges[i, j];                 //边的权值
                        p.nextarc = G.adjlist[i].firstarc;      //采用头插法插入p
                        G.adjlist[i].firstarc = p;
                    }
            G.n = g.n;
            G.e = g.e;
        }
        public string DispALGraph()                            //输出图的邻接表
        {
            string mystr = "";
            int i;
            ArcNode p;
            for (i = 0; i < G.n; i++)
            {
                mystr += "[" + i.ToString() + "]";
                p = G.adjlist[i].firstarc;                      //p指向第一个邻接点
                if (p != null)
                    mystr += " →";
                while (p != null)
                {
                    mystr += " " + p.adjvex.ToString() + "(" + p.weight.ToString() + ")";
                    p = p.nextarc;                              //p移向下一个邻接点
                }
                mystr += "\r\n";
            }
            return mystr;
        }
        public void ListToMat()				                //将邻接表G转换成邻接矩阵g
        {
            int i;
            ArcNode p;
            for (i = 0; i < G.n; i++)
            {
                p = G.adjlist[i].firstarc;
                while (p != null)
                {
                    g.edges[i,p.adjvex] = p.weight;
                    p = p.nextarc;
                }
            }
            g.n = G.n; g.e = G.e;
        }

        //--------------------------------------------------------------------
        public int Getn()                                       //返回图的顶点个数
        {
            return g.n;
        }
        public int Gete()                                       //返回图的边数
        {
            return g.e;
        }
        //---------图的其他运算算法-------------------------------------------
        public int Degree1(int v)                               //通过无向图的邻接矩阵求顶点i的度
        {
            int i, j,d = 0;
            for (j=0;j<g.n;j++)                                 //统计第v行的非0元素个数
                if (g.edges[v,j] !=0 && g.edges[v,j] != INF)
                    d++;
            return d;
        }
        public int Degree2(int v)                               //通过无向图的邻接表求顶点i的度
        {
            int d = 0;
            ArcNode p;
            p = G.adjlist[v].firstarc;
            while (p != null)
            {
                d++;
                p = p.nextarc;
            }
            return d;
        }
        public void Degree3(int v,ref int outs,ref int ins)     //通过有向图的邻接矩阵求顶点i的度
        {
            int i, j;
            outs = ins = 0;
            for (j = 0; j < g.n; j++)                           //统计第v行的非0元素个数为出度
                if (g.edges[v, j] != 0 && g.edges[v, j] != INF)
                    outs++;
            for (i=0;i<g.n;i++)                                 //统计第v列的非0元素个数为入度
                if (g.edges[i,v] !=0 && g.edges[i,v] != INF)
                    ins++;
        }
        public void Degree4(int v, ref int outs, ref int ins)   //通过有向图的邻接表求顶点i的度
        {
            int i;
            outs = ins = 0;
            ArcNode p;
            p = G.adjlist[v].firstarc;
            while (p != null)                                   //统计第v个单链表中的边结点个数
            {
                outs++;
                p = p.nextarc;
            }
            for (i = 0; i < g.n; i++)                           //统计第v列的非0元素个数
            {
                p = G.adjlist[i].firstarc;
                while (p != null)
                    if (p.adjvex == v)
                    {
                        ins++;
                        break;
                    }
                    else p = p.nextarc;
            }
        }
        //---------------------------------------------------------------------
    }
}
