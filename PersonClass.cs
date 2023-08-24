using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


/*
namespace MY_C_practice
{
    public class PersonClass
    {

         string _Name;

        public string Name
        {
            get { return _Name; }   

            set { _Name = value; }

        }

        
         int _age;

        public int age
        {
            get { return _age; }    

            set {
                
                if(value < 0 || value > 200)
                {
                    value = 0;
                }

                _age = value;
            
            
            }
        }

         char _gender;

        public char gender
        {
            //取值的时候执行get
            get { 
                
                if(_gender != '男' && _gender != '女')
                {
                   return  _gender = '男';
                }
                
                return _gender; }
            //当赋值的时候执行set
            set
            {
                _gender = value;
            }   
        }

        public void personFeature()
        {

            Console.WriteLine("I am a handsome boy, and my name is {0} .and my age is {1},\n" +
                "and my gender is {2}",this.Name,this.age,this.gender);

            Console.WriteLine("Do your want come with me together live ");
        }
    }
}
*/

/*

//静态和非静态的区别
namespace MY_C_practice
{

    public class Person
    {

        public static int number;
        public string name;
        public void M1()
        {
            Console.WriteLine("I am a non static  method");
        }
        
        public static void M2()
        {

            Console.WriteLine("I am static method");
        }


        //静态类使用声明静态函数,也不能声明实例成员。
        public static class StaticPerson
         {
            private static string name;



            public static void M2()
            {

                Console.WriteLine("i am here ");
            }
        }
    }

}
*/






namespace MY_C_practice
{
    public class Person
    {
        private string _name;
        private int _age;
        private char _gender;
        private int _math;

        //构造函数的名字要和类的名字一样
        public Person(string name,int age,char gender,int math)
        {
            //构造函数带参数初始化字段
            this.Name = name;
            this.Age = age;    
            this.Gender = gender;  
            this.Math =  math;
        }
        //构造函数是可以重载的


        //1、this关键字，代表当前的对象
        //2、this关键字，在类当中显示的调用本类的构造函数
        public Person(int age,string name ):this(name,age, '女', 111)
        {
     

        }

        public string Name
        {
            get { return _name; }       
            set { _name = value; }

        }
        //get { return m_Data; }
        //get => m_Data;            这两句话是相等的
        public int Age { get => _age; set => _age = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public int Math { get => _math; set => _math = value; }

        
        public void outPerson()
        {
            Console.WriteLine("名字：{0},年龄：{1},性别：{2},数学：{3}",this.Name,this.Age,this.Gender,this.Math);

        }
        
    }

}



