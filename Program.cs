// See https://aka.ms/new-console-template for more information


using Microsoft.VisualBasic;
using MY_C_practice;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;
using static MY_C_practice.Person;


#region MyRegion




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

/*
//16分
//100完
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


*/


/*
namespace 静态和非静态的区别
{
    class program
    {
        static void Main(string[] args)
        {
            Person  per = new Person();
            //总结，静态成员必须使用类名去调用，而实例成员使用对象名调用
            //静态函数中，只能访问静态成员，不允许访问实例成员。
            //实例函数中，既可以使用静态成员，也可以使用实例成员。
        
            //静态类使用时机，当你把类当做一个“工具类”的时候就可以考虑使用静态类了。
            //静态类在整个项目中资源是共享的。（堆、栈、静态存储区域）

            //我是非静态的方法
            per.M1();

            //我是静态方法
            Person.M2();
   
            Console.ReadKey();
        }

    }
}

*/

/*

namespace 构造函数
{
    class program
    {
        static void Main(string[] args)
        {
        
            //创建对象的时候会执行构造函数
            Person murphy = new Person("莫明川",25,'男',120);

            murphy.outPerson();

            Person Daming = new Person(20,"大明");

            Daming.outPerson();

            Console.ReadKey();
        }

    }
}
//106完

*/
#endregion


//109完
/*
namespace 命名空间
{
    class program
    {
        static void Main(string[] args)
        {


            //快捷键 是alt+shif+F10
            //快速提示 应用命名空间

            Console.ReadKey();
        }

    }
}

*/




#region MyRegion



//namespace 值类型和引用类型
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//区别
//值类型和引用类型在内存上存储的地方不一样。
//在传递值类型和传递引用类型的时候，传递的方式不一样。
//值类型：int、 double 、bool 、char、 decimal 、struct、 enum 
//引用类型：string 、自定义类、数组
//值类型的值是存储在内存的栈当中。
//引用类型的是存储在内存的堆当中。

//字符串是不可变性，

//string ss = "abcdfg";
////要想把里面的b改成a,要进行转换
//char[] charS = ss.ToCharArray();

//charS[1] = 'a';

////数组转字符串

//ss = new string(charS);

//Console.WriteLine(ss);
//Console.WriteLine(charS);

//如果你要对字符串大量的修改的时候，得用StringBuilder（）这个对象。
//要是用string字符串的话是花很长的时间。
//StringBuilder（） 完成了在把他\

//StringBuilder sb = new StringBuilder();

//string  str=null;

//Stopwatch sw = new Stopwatch(); 


//创建一个计时器，用来记录运行时间
//sw.Start();

//for (int i = 0; i < 100000; i++)
//{
//    //str += i;
//    sb.Append(i);
//}
//sw.Stop();


//一切类型都是使用 ToString 转换成字符串类型
//Console.WriteLine(sb.ToString());   
//Console.WriteLine(sw.Elapsed);
//Console.WriteLine(sb);

//str = sb.ToString();
//Console.WriteLine("当前的字符串长度为{0}",str.Length);

/*
    #region MyRegion

        string myStr = "fwefwe565rwg";
        //字符串转换为大写
        Console.WriteLine(myStr.ToUpper());
        myStr = "AFWGERHETH";

        //转小写
        Console.WriteLine(myStr.ToLower());

        string mystr2 = "aFWGERHETH";

        if(myStr.Equals(mystr2,StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("你们字符串是相同的");

        }else
        {
            Console.WriteLine("你们的字符串是不相同的");
        }

    #endregion
*/

/*
#region MyRegion

//字符串分割

string s = "f+.-49922-/,,`024356&^$%#80-   ef  ][hthl";

//要去掉的字符
char[] spli = {'+', ',', ' ' };

char[] afwwf = { '+', ',', ' ' };

//第一种方法。
string[] arrayRESULT =  s.Split(spli,StringSplitOptions.RemoveEmptyEntries);

//第二种方法是直接定义后传参。
arrayRESULT = s.Split(new char[] { '.'}, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(arrayRESULT);

#endregion
*/


//#region MyRegion


/*


//字符串 包含和替换
string str = "国家关键人物 啊莫";

if (str.Contains("啊莫"))
{
    //字符串替换
  Console.WriteLine(  str.Replace("啊莫", "**"));
}else
{
    Console.WriteLine(str);
}


//字符串 索引 放回下标值

Console.WriteLine("查找的字符串下标是 {0}",str.IndexOf("啊",2));

//字符串截取

Console.WriteLine( str.Substring(7,2));



//提取最后一个字符串

string path = @"c:\dw\dw莫\wg\gr老师\erg\莫老师.wav";

//两个斜杠是表示一个斜杠，搜索最后一个斜杠并且返回下标

int index = path.LastIndexOf("\\");

path = path.Substring(index+1);


Console.WriteLine(path);


//去空格

Console.WriteLine("当前去除的空格字符串 \"{0}\"",str.Trim() ) ;

//判断字符串是否为空
if (string.IsNullOrEmpty(str))
{

    Console.WriteLine("是为空");
}else
{

    Console.WriteLine("不是为空") ;
}
//字符串加入

string[] names = { "张三","李四","大名","电测" };


string strword = string.Join("|", names);

Console.WriteLine("当前加入的字符串为,{0}", strword);
//*/
//#endregion


//#region MyRegion
///*

////string path = @"C:\Users\murphy\Desktop\新建文本文档.txt";
//////文件操作
//string [] contents =  File.ReadAllLines(path,Encoding.Default);

////打印出文件数据
//for (int i = 0; i < contents.Length; i++)
//{
//    Console.WriteLine(contents[i]);
//}




//string str = "hello**c#**sharp";
////字符串分割

//string[] resultStr = str.Split('*');

//for (int i = 0; i < resultStr.Length; i++)
//{
//    Console.WriteLine(resultStr[i]);   
//}

//#endregion


//*/


//            Console.ReadKey();
//        }

//    }
//}


#endregion


/*
namespace 继承
{

//new 的用法，1、创建对象，2、隐藏从父类继承过来的同名成员，隐藏的后果是子类用不到父类的成员

    //我们可能在一个类中使用一些重复的成员，这些成员可以写成一个类，叫做父类
    //然后子类都可以使用父类的东西
    //类的特性：
    //1、继承的单根性：子类继承了父类的属性和方法，但是子类没有继承父类的私有字段
    //2、继承的传递性：

    class program
    {
        static void Main(string[] args)
        {
            student murphy = new student("murphy",24,'男',631001833);
            Teacher Daming = new Teacher("cady", 24, '女', 20000);

            murphy.studentOut();
            Daming.teacherOut();

            Console.ReadKey();
        }
    }


    //声明一个父类，放公共的字段数据
    public class human
    {

        //声明构造函数
        public human(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        private  string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private char _Gender;
        public char Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public void com()
        {
            Console.WriteLine("我是一个人类");
        }

    }

    //子类继承父类的东西
    public class student: human
    {
         private static int _ID;
     
        //声明构造函数
        //子类要调用父类的有参数的构造函数，
        //这个是调用了父类的构造函数，父类的就不用重新赋值了，剩余的参数要赋值
        public student(string name, int age, char gender, int id) : base(name, age, gender)
        {
            this.ID = id;
        }
       
        public int ID
        {
            get { return _ID; } 
             set { _ID = value; }
        }
        public  void studentOut()
        {
           
            Console.WriteLine("我是一个学生类,我的名字是 {0}，" +
                "我的年龄是 {1},我的学号是 {2}，我的性别是 {3}", this.Name,this.Age,this.ID,this.Gender);

        }

    }
    //子类继承父类的东西
    public class Teacher: human
    {

        public Teacher(string name, int age, char gender, int salary) : base(name, age, gender)
        {
            this.Salary = salary;
        }

        private static int _Salary;
        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        
        public void teacherOut()
        {
            Console.WriteLine("我是一个老师类，我的名字是 {0}， 我的年龄是 {1}" +
                "我的性别是 {2}，我的薪水是 {3}",this.Name,this.Age,this.Gender,this.Salary);
        }
        
       
    }
    //子类继承父类的东西
    public class Driver: human
    {
        public Driver(string name, int age, char gender, int driverTime) : base(name, age, gender)
        {
            this.DriverTime = driverTime;
        }
        private int _DriverTime;

        public int DriverTime
        {

            get { return _DriverTime; }
            set { _DriverTime = value; }    

        }
        public void DriverOut()
        {
            Console.WriteLine("我是一个司机类");

        }

    }
}

//19分


*/
//11

namespace  里氏传换
{

    //1、子类可以赋值给父类，如果有一个地方需要一个父类作为参数，我们可以给一个子类代替
    //2、如果父类中装的是子类对象，那么可以讲这个父类抢转为子类对象
    //3、
    public class main
    {

        static void Main(string[] args)
        {


            #region MyRegion

                //person p = new student();

                //is  是 如果p是teacher 则返回一个 true，否者就返回 false

                //if(p is teacher)
                //{
                //    //因为p 装的是Student ， student 和 teacher 他们没有关系
                //    teacher ss = (teacher)p;
                //    ss.teacherMethod();
                //}else 
                //{
                //    Console.WriteLine("conversion fail ");
                //}



                //方法2 
                //as ，是如果是转换成功则返回转换的对象，不行则返回null
                //teacher t = p as teacher;

                //student t1 = p as student;

                //t1.studentMethod();

                //string str =  string.Join("|", new string[] { "1", "2", "3", "4" });

                // Console.WriteLine(str);


            #endregion



            //student s = new student();
            //person p = new person();
            //teacher t = new teacher();


            person[] pers = new person[10];

            //新建一个随机数

            Random rr = new Random();

            for (int i = 0; i < pers.Length; i++)
            {

                int number = rr.Next(1, 3);

                switch (number)
                {
                    case 1:
                        pers[i] = new person();
                        break;
                    case 2:
                        pers[i] = new student();
                        break;
                    case 3:
                        pers[i] = new teacher();
                        break;
                    default:

                        break;
                }
            }





            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i] is student)
                {
                    ((student)pers[i]).studentMethod();
                }
                else if (pers[i] is teacher)
                {
                    ((teacher)pers[i]).teacherMethod();
                }
                else if (pers[i] is person)
                {
                    ((person)pers[i]).personMethod();
                }
            }
        





    }

    }





    public class person
    {

        public void personMethod()
        {
            Console.WriteLine("I am s person");
            
        }
    }

    public class  student:person
    {
        public void studentMethod()
        {

            Console.WriteLine("I am a student ");
        }
        

    }

    public class teacher:person
    {
        public void teacherMethod()
        {

            Console.WriteLine("I am a teacher");
        }



    }
}



