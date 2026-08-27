using System;

namespace Day02CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem01
            //int x = 10;
            //int y = 20;
            //int sum = x + y;
            //Console.WriteLine(sum);

            /*
                int x = 10;
                int y = 20;
                int sum = x + y;
                Console.WriteLine(sum);
             */
            #endregion

            #region Question01
            //  Ctrl+/
            #endregion

            #region Problem02
            int x = 10;
            int y = 5;

            Console.WriteLine(x + y);
            #endregion

            #region Question02
            /*
             Runtime Error:
             An error that happens while the program is running. The program may compile successfully, but an error occurs during execution.

             Example:
             Dividing a number by zero causes a runtime error.

             Logical Error:
             An error where the program runs successfully but gives an incorrect result because the logic is wrong.

             Example:
             Calculating an employee’s salary using the wrong formula. The program runs normally, but the final salary is incorrect.
             */
            #endregion

            #region Problem03
            // تم تغيير الاسم هنا كما طلبت
            string FullName = "Mostafa Mahmoud";
            int Age = 22;
            decimal Salary = 14000;
            bool IsStudent = true;
            #endregion

            #region Question03
            /*
             Following naming conventions like PascalCase makes C# code easier to read, understand, maintain, and consistent across a project.
             */
            #endregion

            #region Problem04
            Person p1 = new Person();
            p1.Name = "Ahmed";

            Person p2 = p1;

            p2.Name = "Mohamed";

            Console.WriteLine(p1.Name); // Mohamed
            Console.WriteLine(p2.Name); // Mohamed
            #endregion

            #region Question04
            /*
             Value Types: Store the actual value directly. Each variable has its own copy of the data.
             Reference Types: A variable stores a reference to an object. Multiple variables can reference the same object in memory.
             */
            #endregion

            #region Problem05

            int x1 = 15;
            int y1 = 4;

            Console.WriteLine("Sum = " + (x1 + y1));
            Console.WriteLine("Difference = " + (x1 - y1));
            Console.WriteLine("Product = " + (x1 * y1));
            Console.WriteLine("Division = " + ((double)x1 / y1));
            Console.WriteLine("Remainder = " + (x1 % y1));
            #endregion

            #region Question05
            /*
             The output will be: 2
                  Why?
                    The % operator returns the remainder after division.
                    Since 2 is smaller than 7, 7 cannot divide into 2, so the remainder is still 2.
             */
            #endregion

            #region Problem06
            int number = 14;

            if (number > 10 && number % 2 == 0)
                Console.WriteLine("The number is greater than 10 and even");

            else
                Console.WriteLine("The number does not meet both conditions");
            #endregion

            #region Question06

            /*
              (Logical AND): Used with Boolean conditions and returns true when both conditions are true. It uses short-circuit evaluation, so it may skip the second condition.

              (Bitwise AND): Used mainly with numbers to compare their bits. When used with Boolean values, it evaluates both conditions.
             */
            #endregion

            #region Problem07
            Console.Write("Enter a number: ");
            double x2 = double.Parse(Console.ReadLine());

            // Implicit Casting
            double y2 = x2;

            // Explicit Casting
            int z2 = (int)x2;

            Console.WriteLine("Implicit = " + y2);
            Console.WriteLine("Explicit = " + z2);
            #endregion

            #region Question07
            /*
             Explicit casting is required because converting double to int may cause data loss
            */
            #endregion

            #region Problem08
            int x3 = 5;

            Console.WriteLine(++x3); // Prefix
            Console.WriteLine(x3++); // Postfix
            Console.WriteLine(x3);
            #endregion

            #region Question08
            /*
                The value of x is 7.
                x starts with 5.
                ++x increases it to 6 before using it.
                Then x++ uses 6 and increases it to 7 afterward
            */
            #endregion
        }
    }

    // يُفضل وضع كلاس Person كـ class مستقيمة داخل الـ Namespace خارج كلاس Program
    public class Person
    {
        public string Name { get; set; }
    }
}