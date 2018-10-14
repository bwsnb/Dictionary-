using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary泛型集合之基本使用
{
    class Program
    {
        static void Main(string[] args)
        {

            PhoneController pc = new PhoneController();

            Console.WriteLine("***************************\n**********电话簿***********\n***************************\n");
            while (true)
            {
                
                Console.WriteLine("1.添加号码\n2.删除号码\n3.修改号码\n4.查询所有号码");
                int num = int.Parse(Console.ReadLine());


                switch (num)
                {
                    case 1:
                        Console.Write("请输入姓名：");
                        string name = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("请输入电话号码：");
                        string number = Console.ReadLine();
                        Console.WriteLine();
                        pc.AddNumber(name, number);
                        break;
                    case 2:
                        pc.ShowAllNumber();
                        Console.Write("请输入要删除号码的姓名：");
                        string Rname = Console.ReadLine();
                        pc.RemoveNumber(Rname);
                        break;
                    case 3:
                        pc.ShowAllNumber();
                        Console.WriteLine("请输入要修改号码的姓名：");
                        string Cname = Console.ReadLine();
                        pc.RemoveNumber(Cname);
                        break;

                    case 4:
                        pc.ShowAllNumber();
                        break;

                }
            }


            Console.ReadKey();

        }
    }
}
