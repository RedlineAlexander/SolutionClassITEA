﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1. Создали класса
2. Добавили в него 3 свойства
3. Добавили 2 поля
4. Добавили свойства для этих полей, одно свойство только get, другое get/set, но сет только для класса (модификатор доступа)
5. Конструктор с параметрами на 3 поля которые были в начале
6. 2 метода - один возвращает значение, другой нет, один с параметрами, другой без
7. Статический метод и поле, для подсчета количества созданных объектов
8. Абстрактный класс с абстрактным и виртуальным методом
9. Ваш изначальный класс должен унаследовать абстрактный и переопределить методы
10. Добавьте интерфейс, добавьте метод и свойство, ваш класс(изначальный) должен реализовывать этот интерфейс
11. Добавьте интерфейс, в нем метод, полностью совпадающий с методом из интерфейса с задания 10. Класс должен реализовать разное поведение метода, который он реализует от разных интерфейсов
Подсказка
%InterfaceNam
12.Создайте класс Extensions, в него добавьте extension метод для вашего изначального класса
 */
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
    interface IInterface1
    {
        void ShowITInterface();

    }

    public abstract class abstractClass
    {
        public abstract string abstractStringMethod();
       // public abstract virtual string abstractStringMethod(); НЕЛЬЗЯ!!!!
        public virtual int counterNonAbstractMethod()
        {
            return 1;
        }
    }
    public sealed class Class:abstractClass, IInterface, IInterface1
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
        public string HelloITEAInterface { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void ShowITInterface()
        {
            throw new NotImplementedException();
        }

        public override string abstractStringMethod()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"({field1} {field2})";
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            var other = (Class)obj;

            return (this.field1 == other.field1) && (this.field2 == other.field2);
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
           public static   class Extensions
           {
            public static void ClassExtensionMethod(this Class @class, string stringClass)
                 {

                   }
            }
            class Program
            {
                static void Main()
                {
                    //Class instanceClass = new Class();

                }
            }

}

    

