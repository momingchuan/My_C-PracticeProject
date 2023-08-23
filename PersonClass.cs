using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
