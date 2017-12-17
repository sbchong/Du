using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du
{
    class SqListClass
    {
        const int MaxSize = 100;
        public string[] data;
       
        public int length;
        public SqListClass()
        {
            data = new string[MaxSize];
           
            length = 0;

        }

        public void CreatList(string[] split)//创建一个顺序表
        {
            int i;
            for (i = 0; i < split.Length; i++)
                data[i] = split[i];
            length = i;
           
        }
        public string DispList()//显示输出
        {
            int i;
            if (length > 0)
            {
                string mystr = data[0];
                for (i = 1; i < length; i++)
                    mystr += "," + data[i];
                return mystr;
            }
            else return "你还没输入任何数据";
        }

        public int ListLength()//获取顺序表长度
        { return length; }
        

        public bool GetElem(int i, ref string e)//按序号找到的元素值
        {
            if (i < 1 || i > length)
                return false;
            e = data[i - 1];
            return true;
        }
        public int LocateElem(string e)//按元素查找位置
        {
            int i = 0;
            while (i < length && string.Compare(data[i], e) != 0)
                i++;
            if (i >= length)
                return 0;
            else
                return i + 1;


        }

        public bool ListInsert(int i, string e)//按序号插入元素
        {
            int j;
            if (i < 1 || i > length + 1)
                return false;
            for (j = length; j >= i; j--)
                data[j] = data[j - 1];
            data[i - 1] = e;
            length++;
            return true;

        }
        
        public void  ListDelete(int i)//按顺序删除元素
        {
            int j;
            string e;
            if (i < 1 || i > length)
                return  ;
          
            for (j = i - 1; j < length - 1; j++)
                data[j] = data[j + 1];
            length--;
            e = data[j];
        
        }
       
    }

}

