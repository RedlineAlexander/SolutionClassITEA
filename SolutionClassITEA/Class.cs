using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionClassITEA
{
    public interface IInterface
    {
        //public ошибка компиляции 
        string HelloITEAInterface
        {
            get;
            set;
        }
        void ShowITInterface();
    }

    public abstract class abstractClass
    {
        public abstract string abstractStringMethod();
        public virtual int counterNonAbstractMethod()
        {
            return 1;
        }
    }
    class Class
    {


        private int field1;
        private string field2;

        public int Field1
        {
            get { return field1; }
            //   set { field1 = value; }

        }
        public string Field2

        {
            get { return field2; }
            private set { field2 = value; }
        }



        public int property_1
        {
            get;
            set;
        }
        public string property_2
        {
            get;
            set;
        }
        public double property_3
        {
            get;
            set;
        }

        public Class(int property_1, string property_2, double property_3)
        {

            this.property_1 = property_1;
            this.property_2 = property_2;
            this.property_3 = property_3;

        }


        public void method_1(int field1, string field2)
        {

        }
        public int method_2()
        {
            return field1;
        }

/*
        public static string ReturnCountVariable(int counter)
        {
            public static string string_one;

        public static int a;
        public static int b;
        public static int c;

     //   a = 1;
      //  b = a++;
     //       c = ++a;

       // counter++;
            return 0;
            }
            */
        }

}

    

