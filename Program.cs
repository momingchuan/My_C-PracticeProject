// See https://aka.ms/new-console-template for more information


using Microsoft.VisualBasic;
using MY_C_practice;
using System.Diagnostics;
using System.Runtime.InteropServices;
/*

namespace myProject
{


    class project
    {
        static void Main(string[] args)
        {
            string name = "murphy";
            int age = 24;
            //占位符
            Console.WriteLine("my name is {0}, my age is {1} ,", name, age);
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}


*/

/*
namespace myProject
{


    class project
    {
        static void Main(string[] args)
        {
            string myname;
            Console.WriteLine("please input your name ");
            myname = Console.ReadLine();
            Console.WriteLine("your name is {0}",myname);
            Console.ReadKey();
        }
    }
}
*/
//P19 完


/*
 * 转移字符
 * 
 *      \n     回车
 *      \      一个\加一个半角的英文符号就是输出这个英文符号，如   \"   输出 "
 *      \t     一个teb键，tab键一般是几个空格不同的编译器空格数量不一样
 *      \b     退格键，放到字符串的两边是没有效果
 *      \r\n  windows 操作系统不认识\n，只认识\r\n
 *      \\    表示一个\
 *      
 *      
 *      @     取消里面的字符串的转移字符作用
 *      如 ：
 *      string path=@"F:\文件\abc\资料"；
 *      这个是一个路径地址
 *      
 * 
 */

/*
namespace myProject
{
    class project
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"that day is wonderful
in the day");
            //@是按原格式输出  
        }
    }
}

*/

/*
namespace myProject
{
    class project
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 3;
            double add = (double)n1 / n2;
            //:0.00 是保留两位小数点 ：0.000 保留三位小数点
            Console.WriteLine("this number add is {0:0.00}",add);
           
        }
    }
}
*/
/*
namespace myProject
{
    class project
    {
        static void Main(string[] args)
        {
            string s1 = "154";
            int ABC;
            double A;
            
            ABC =  Convert.ToInt16(s1);
            A = Convert.ToDouble(s1);
            Console.WriteLine(A);
            Console.WriteLine(ABC);

        }
    }
}
*/
//27 over 

/*

namespace _异常捕获
{
    class program
    {

        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("please input a number .");
            
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("your input the number is {0}",number);
            }
            catch
            {
                Console.WriteLine("your input is error number. please re-enter the number");
            }
           
            
           
        }
    }
}
*/




/*

namespace 类型转换
{
    class program
    {

        static void Main(string[] args)
        {
            int number = 0;

            string Str = "64566";
            int temp = 0;
            bool result =  int.TryParse(Str, out temp);
            Console.WriteLine("the out result number is {0} and the string number is {1}",result,temp);

        }
    }
}

*/



/*

namespace 产生随机数
{
    class program
    {

        static void Main(string[] args)
        {

            int i = 10;
            //新建一个对象，
            Random num = new Random();

            while(i-->1)
            {
                int number = num.Next(1,500);
                Console.WriteLine("the random number is {0}", number);
            }
        }
    }
}

*/

/*
namespace 常量
{
    class program
    {

        static void Main(string[] args)
        {
            const int num = 100;

        }
    }
}

*/




//66完
/*
namespace 枚举
{


    public enum gender
    {
        man,
        women,
        child
           

    }
    class program
    {

        static void Main(string[] args)
        {

            gender mygender = gender.women;
            Console.WriteLine("this is {0}", mygender);
            //强行转换类型
            int mynumber = (int)gender.women;
            Console.WriteLine("{0}", mynumber);

            //所有的类型都可以转换成字符串类型

            string s = mynumber.ToString();
            Console.WriteLine("{0}", s);


            //把字符串类型强制转换成枚举类型
            string my_s = "1";
            gender mydefine = (gender)Enum.Parse(typeof(gender), my_s);


            Console.WriteLine("cast number is {0}", mydefine);
            


        }
    }
}

*/



/*

namespace 结构类型
{

    public enum gender
    {
       man,
       women,
       child
    }
    public struct information
    {
        public int _age;//这个是字段是要声明为public才可以访问，字段和变量是不一样的。一个字段可以存储很多个值。而变量只可以存储一个值。
        public string _name;//字段开头一般要加下划线
        public gender _gander;
    }
    class program
    {

        static void Main(string[] args)
        {
            information person1;
            person1._age = 25;
            person1._name = "murphy";
            person1._gander = gender.man;

            Console.WriteLine("your age is {0}.\nyour name is {1}.\nyour gander is {2}.",person1._age, person1._name, person1._gander);
            

        }
    }
}

*/

/*
namespace 数组类型
{
    class program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];//定义一个数组类型为int 长度为10

            int[] array2 = { 0, 5, 4, 5, 2, 7 ,0};//数组声明方式
            int[] array5 = {4,544,564,2,42,5,4 };//数组声明方式

            int[] array3 = new int[6] { 4, 6, 4, 7, 1, 4 };//数组声明方式

            int[] array4 = new int[] { 4, 458, 1, 65, 7 };//数组声明方式

            array1[0] = 10;

            Array.Sort(array2);//升序排列

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.WriteLine("\n");
            Array.Sort(array5);//升序排列
            Array.Reverse(array5);//反转排列

            for (int i = 0; i < array5.Length; i++)
            {
                Console.WriteLine(array5[i]);
            }

        }
    }
}

*/




/*


namespace 方法
{
    class program
    {

        static void Main(string[] args)
        {
            //调用方法是使用类名加点方法名
            //如果你的方法跟main函数同一个类的话是可以省略类名的，如果不是同一个类，不能省略类名
            MY_Method(); //main同一个类调用
            program.MY_Method();//main不同类调用


      

        }

        /// <summary>
        /// 方法调用
        /// </summary>
        public static void MY_Method()
        {
            
            Console.WriteLine("this is a method funtion hello erger are your here ?  now here what are your problem ");
            Console.WriteLine("yes now we are successfully hihihi dwdwhjmj  hello gergrerrgre");

        }
    }
}
//77 6.40



*/

/*
namespace 方法out
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的用户名");
            string  name = Console.ReadLine();
            Console.WriteLine("请输入你的密码");
            string pwd = Console.ReadLine();
            string outmess;

             bool key = IsLogin(name, pwd, out  outmess);
            Console.WriteLine("登入结果: {0}",key);
            Console.WriteLine("登入状态: {0}",outmess);

        }


        public static bool myTryParse(string s, out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch 
            {

                return false;
            }


        }
        /// <summary>
        ///  判断登入是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">多余返回的登入信息</param>
        /// <returns>返回登入结果</returns>

        public static bool IsLogin(string name ,string pwd , out string msg)
        {
            if(name == "murphy" && pwd == "123456")
            {
                msg = "登入成功";
                return true;
            }else if (name == "murphy")
            {
                msg = "密码错误";
                     return false;
            }
            else if(pwd == "123456")
            {
                msg = "账号错误";
                return false;
            }else
            {
                msg = "账号和密码都有误";
                return false;
            }
        }
    }
}

*/



/*
namespace 方法ref
{
    class program
    {

        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;

            test(ref n1, ref n2);
            Console.WriteLine("n1 is {0}", n1);
            Console.WriteLine("n2 is {0}", n2);
        }
        public static void test (ref int n1,ref int n2)
        {

            int temp = n1;
            n1 = n2;
            n2 = temp;
            
        }
    
    }
}

*/



/*

namespace 方法params
{
    class program
    {
        static void Main(string[] args)
        {
            test("murphy", 48, 50, 50);
        }

        /// <summary>
        /// 可变参数，但是类型要保持一致，params 一定要放到参数的最后面一个参数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        public static void test(string name,params int[] score )
        {
            int sum = 0;

            for (int i = 0; i < score.Length; i++)
            {
                sum+=score[i];
            }
            Console.WriteLine("{0}你这次考试的成绩是{1}",name,sum);  
        }


    }
}

//82 完
*/


/*

namespace 方法重载和方法递归
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine( M1(1, false));

            MyRecursion();

        }

        //方法的重载跟返回值没有关系，方法的使用相同分参数类型就不能相同的个数，
       // 相同个数就， 不能相同的类型。
       

        public static int M1(int n1, int n2)
        {
            return n1 + n2;

        }
        public static int M1(int n1, bool n2)
        {
            if(n2)
            {
                return n1;
            }
            else
            {
                return 0;

            }
         
        }

        //方法递归
       public static int i=0;
        
        public static void  MyRecursion()
        {
            Console.WriteLine("hi every one {0}",i);

            if(i>5)
            {

                return;
            }else
            {
                i++;
            }
            MyRecursion();
        }
    }
}




*/


/*
namespace 飞行棋
{
    class program
    {

        static int[] Maps = new int[100];
        static int[] playerLocation = new int[2];
        static void Main(string[] args)
        {
            gameShow();
            InitMap();
            mapsShow();
            Console.ReadKey();


        }


        public static void gameShow()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********飞行棋启动****V0.0***");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*******莫明川制作 2023.8.22*****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************");
        }

        public static void InitMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };

            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 95 };
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88 };
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }


        }

        public static void mapsShow()
        {

            for (int i = 0; i < 30; i++)
            {
                if (playerLocation[0] == playerLocation[1] && playerLocation[0] == i)
                {
                    Console.Write("<>");
                }
                else if (playerLocation[0] == i)
                {
                    //shift + 空格  切换全角
                    Console.Write("A");

                }
                else if (playerLocation[1] == i)
                {
                    Console.Write("B");
                }
                else
                {
                    switch (Maps[i])
                    {
                        case 0:
                            {
                                Console.Write("口");
                            }

                            break;
                        case 1:
                            {
                                Console.Write("○");

                            }

                            break;
                        case 2:
                            {
                                Console.Write("●");

                            }
                            break;
                        case 3:
                            {
                                Console.Write("△");

                            }
                            break;
                        case 4:
                            {
                                Console.Write("X");

                            }
                            break;
                    }
                }
            }

        }

    }
}

*/


//16分

namespace 面向对象类
{
    class program
    {
        static void Main(string[] args)
        {
            //新建一个类
            PersonClass murphy = new PersonClass();

            murphy.Name = "发财";
            murphy.age = -25;
            murphy.gender = '单';

            murphy.personFeature();


            Console.ReadKey();






        }



 

      
    }
}










