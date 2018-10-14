using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary泛型集合之基本使用
{
    /// <summary>
    /// C.控制器层
    /// </summary>
    class PhoneController
    {
        //
        Dictionary<string, string> dic = new Dictionary<string, string>();

        
        /// <summary>
        /// 增加电话号码
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        public void AddNumber(string name,string number)
        {
            if (dic.ContainsKey(name))
            {
                Console.WriteLine("已存在用户");
            }
            else
            {
                dic.Add(name, number);
            }
            

        }

        public void RemoveNumber(string name)
        {
            dic.Remove(name);
        }

        public void ChangeNumber(string name, string number)
        {
            dic[name] = number;
        }

        public void ShowAllNumber()
        {
            foreach (var item in dic.Keys)
            {
                Console.WriteLine($"姓名：{item}，电话号码：{dic[item]}");
            }
        }

    }
}
