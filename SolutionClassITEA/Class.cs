using System;
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
13. Переопределите метод ToString и Equals для вашего класса
14. Запретите наследование вашего основного класса
15. Создайте свой класс Exception. Переопределите конструкторы. Добавьте отлов ошибок в метод Main
16. Добавьте enum для дней недели
 */
namespace SolutionClassITEA
{
    //10. Добавьте интерфейс, добавьте метод и свойство, ваш класс(изначальный) должен реализовывать этот интерфейс
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
    //11. Добавьте интерфейс, в нем метод, полностью совпадающий с методом из интерфейса с задания 10. Класс должен реализовать разное поведение метода, который он реализует от разных интерфейсов
    //Подсказка
//%InterfaceNam
    interface IInterface1
    {
        void ShowITInterface();

    }
    //8. Абстрактный класс с абстрактным и виртуальным методом
    public abstract class abstractClass
    {
        public abstract string abstractStringMethod();
       // public abstract virtual string abstractStringMethod(); НЕЛЬЗЯ!!!!
        public virtual int counterNonAbstractMethod()
        {
            return 1;
        }
    }
    //9. Ваш изначальный класс должен унаследовать абстрактный и переопределить методы
    //13. Переопределите метод ToString и Equals для вашего класса
    //14. Запретите наследование вашего основного класса
    public sealed class Class : abstractClass, IInterface, IInterface1
    {


        private int field1;
        private string field2;

        public int Field1
        {
            get { return field1; }
          

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

        //6. 2 метода - один возвращает значение, другой нет, один с параметрами, другой без
        public void method_1(int field1, string field2)
        {
            field1 = 12;
            field2 = "KUHAROO";
        }
        public int method_2()
        {
            return field1;
        }
        //11. Добавьте интерфейс, в нем метод, полностью совпадающий с методом из интерфейса с задания 10. Класс должен реализовать разное поведение метода, который он реализует от разных интерфейсов
        //Подсказка
        //%InterfaceNam
        public void ShowITInterface()
        {


            Console.WriteLine("Welcome to Totus in Farmastor, dear ");
            //throw new NotImplementedException();
        }

        public override string abstractStringMethod()
        {
            Console.WriteLine("Welcome");
            return "Welcome to the abstractStringMethod";
           // throw new NotImplementedException();
        }
        public override int counterNonAbstractMethod()
        {
            return base.counterNonAbstractMethod();
        }
        // 13. Переопределите метод ToString и Equals для вашего класса
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
        //7. Статический метод и поле, для подсчета количества созданных объектов
        public static int ITEAEmployeeCounter;
        public static int AddEmployee()
        {
            return ++ITEAEmployeeCounter;
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
    //12.Создайте класс Extensions, в него добавьте extension метод для вашего изначального класса
    public static class Extensions
    {
         public static void ClassExtensionMethod(this Class @class, string stringClass)
            {

            }
    }

    //15. Создайте свой класс Exception.Переопределите конструкторы.Добавьте отлов ошибок в метод Main
    public class MyFirstException : Exception
    {

        public MyFirstException(string message):base(message)
        {

        }
    }
    //16. Добавьте enum для дней недели
    enum DaysOfWeek {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}

            class Program
            {
                static void Main()
                {
            //Class instanceClass = new Class();
        //    Class @class = new Class(1, "Alexander", 4000.00);
          //  Class @class2 = new Class(2, "Berdychev", 6000.00);


           // @class.ToString();
         //   class2.ToString();

            //  @class.Equals(@class, @class);
            try
            {

                Class @class = new Class(1, "Alexander", 4000.00);
                Class @class2 = new Class(2, "Berdychev", 6000.00);

                //свойства вывели 0 
              Console.WriteLine  (@class.ToString());
              Console.WriteLine  (class2.ToString());
                Console.WriteLine(@class.Field1);
                Console.WriteLine(@class.Field2);
                //     Console.WriteLine(ShowITInterface());
                class2.ShowITInterface();
            }
            catch(MyFirstException ce)
            {
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("Anyway so anyway bro. Go in ITEA");
            }
            Console.ReadKey();
                }
            }

}

    

