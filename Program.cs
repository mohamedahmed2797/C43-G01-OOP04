namespace assignment_oop_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to
            //Calculator calculator = new Calculator();
            //int intNumbers = calculator.Add(10, 20);
            //Console.WriteLine(intNumbers);
            //intNumbers = calculator.Add(10, 20, 30);
            //Console.WriteLine(intNumbers);
            //double doubleNumbers = calculator.Add(10.5, 10.5);
            //Console.WriteLine(doubleNumbers);
            #endregion
            #region Q2) Create a class named Rectangle with the following constructors
            //Rectangle rectangle = new Rectangle();
            //Console.WriteLine(rectangle);
            //Rectangle rectangle1 = new Rectangle(10,20);
            //Console.WriteLine(rectangle1);
            //Rectangle  rectangle2 = new Rectangle(50);
            //Console.WriteLine(rectangle2);
            #endregion
            #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
            // ComplexNumber complexNumber1 = new ComplexNumber() { Imaginary = 27 , Real = 17};
            // ComplexNumber complexNumber2 = new ComplexNumber() { Imaginary = 10 , Real = 20};
            //ComplexNumber complexNumber = complexNumber1 + complexNumber2;
            // Console.WriteLine(complexNumber1);
            // Console.WriteLine(complexNumber2);
            // Console.WriteLine("========");
            // Console.WriteLine(complexNumber);
            // Console.WriteLine("----------------------");
            //  complexNumber = complexNumber1 - complexNumber2;
            // Console.WriteLine(complexNumber1);
            // Console.WriteLine(complexNumber2);
            // Console.WriteLine("========");

            // Console.WriteLine(complexNumber);
            #endregion
            #region  Q4)Create a base class named Employee with method That Work as it prints    "Employee is  working
            //Employee employee = new Employee();
            //Console.WriteLine(employee);
            //Manager manager = new Manager();
            //Console.WriteLine(manager);
            #endregion
            #region Question 5
            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage();
            //BaseClass derivedClass1 = new DerivedClass1();
            //derivedClass1.DisplayMessage();
            //BaseClass derivedClass2 = new DerivedClass2();
            //derivedClass2.DisplayMessage();
            //DerivedClass2 derived2 = new DerivedClass2();
            //derived2.DisplayMessage();
            #endregion
            #region Part02
            Duration D1 = new Duration(1, 10, 15);
            D1.ToString();
            Console.WriteLine(D1);
            D1 = new Duration(3600);
            Console.WriteLine(D1.ToString());
            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());
            Console.WriteLine("-------------------");
            D3 = D1 + D2;
            Console.WriteLine(D3);
            D3 = D1 + 7800;
            Console.WriteLine(D3);
            D3 = 666 + D3;
            Console.WriteLine(D3);
            D3 = ++D1;
            Console.WriteLine(D3);
            D3 = --D2;
            Console.WriteLine(D3);
            D1 = D1 - D2;
            Console.WriteLine(D1);
            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }
            else if (D1 < D2)
            {
                Console.WriteLine("D2 is greater than D1");
            }
            if (D1 <= D2)
            {
                Console.WriteLine("D1 is less than or equal to D2");
            }
             D1 = new Duration(25, 70, 75);
            DateTime dateTimeObj = (DateTime)D1;



        }

        #endregion
    }
    }

