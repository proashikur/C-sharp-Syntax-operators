using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{



    class person
    {
        public string name;
        public int age;

        /*public void PrintData()
        {
            Console.WriteLine($"Name : {name}, Age :{age} ");
        }*/



        public void Setvalu( string n, int a) {
            name = n; 
            age = a;
        }

        public void PrintData()
        {
            Console.WriteLine($"Name : {name}, Age :{age} ");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int x = 5;
            int y = 6;
            Console.WriteLine(x - y); // Print the value of x + y */

            //int x, y, z;
            //x = y = z = 50;
            //Console.WriteLine(x + y + z);

            //int myNum = 5;               // Integer (whole number)
            //double myDoubleNum = 5.99D;  // Floating point number
            //char myLetter = 'D';         // Character
            //bool myBool = true;          // Boolean
            //string myText = "Hello";     // String  

            // int myNum = 100000;
            //Console.WriteLine(myNum);
            // int myInt = 10;
            //double myDouble = 5.25;
            // bool myBool = true;

            //Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            // Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            // Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            // Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            // int time = 20;
            //  if (time < 18)
            {
                //     Console.WriteLine("Good day.");
            }
            //  else
            {
                //    Console.WriteLine("Good evening.");
            }
            /*int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."  */

            // int time = 20;
            //if (time < 18)
            {
                //    Console.WriteLine("Good day.");
            }
            // else
            {
                //   Console.WriteLine("Good evening.");
            }

            string fullName = "ashikur rahman";
            int age = 30;
            double gpa = 4.00;
            bool isRagistered = true;
            string bloodGroup = "B+";


            string name = "Apple iphone 16";
            string price = "$320.5";
            string category = "smart phone";
            bool available = true;
            int sold = 5;





            Console.WriteLine(fullName);
            Console.WriteLine(age);
            Console.WriteLine(isRagistered);
            Console.WriteLine(bloodGroup);
            Console.WriteLine(name);
            Console.WriteLine(price);
            Console.WriteLine(category);
            Console.WriteLine(available);
            Console.WriteLine(sold);

            //CONSTAND VALUE

            const string thisisPermanentvalue = "Constant valu print use korar way";

            Console.WriteLine(thisisPermanentvalue);

            //multipulvariable

            int number1 = 10;
            int number2 = 10;
            int number3 = 10;

            number1 = number2 = number3 = 10;


            Console.WriteLine(number1);


            //typecusting

            double salary = 2567.23;
            Console.WriteLine(salary);

            int salary2 = (int)salary;
            Console.WriteLine(salary2);

            double nam = 2746.58;

            Console.WriteLine(nam);

            int num1 = (int)nam;
            Console.WriteLine(num1);

            // implict / auto
            // char->int->long->float->double

            //int salary = 2547; 
            // Console.WriteLine(salary);

            // char salary2= (char) salary;
            // Console.WriteLine(salary2);

            int beton = 2764;
            Console.WriteLine(Convert.ToString(beton));

            // double number = 10.5;
            //int number2= (int) number;
            // Console.WriteLine($"number: {number2}");


            int result = 30 + 20;
            Console.WriteLine(result);

            //operators

            int ashik = 10;
            int num2 = 3;
            int num3 = ashik + num2;

            Console.WriteLine("Additions:" + num3);
            Console.WriteLine(ashik * num2);
            Console.WriteLine(ashik / num2);
            Console.WriteLine(ashik % num2);

            int sub = ashik - num2;

            Console.WriteLine("substraction :" + sub);

            int mul = ashik * num2;
            Console.WriteLine("multification:" + mul);
            int mul2 = ashik % num2;

            Console.WriteLine("mudulas :" + mul2);

            //Arithmetic Operators

            int numBer1 = 10;
            int numBer2 = 3;
            int resulT;

            resulT = numBer1 + numBer2;

            Console.WriteLine($"{numBer1} + {numBer2} = {resulT} ");
            Console.WriteLine("{0} + {1} = {2}", numBer1, numBer2, resulT);

            resulT = numBer1 - numBer2;

            Console.WriteLine($"{numBer1} - {numBer2} = {resulT} ");
            Console.WriteLine("{0} - {1} = {2}", numBer1, numBer2, resulT);

            resulT = numBer1 * numBer2;

            Console.WriteLine($"{numBer1} * {numBer2} = {resulT} ");
            Console.WriteLine("{0} * {1} = {2}", numBer1, numBer2, resulT);

            double div = (double)numBer1 / numBer2;

            Console.WriteLine($"{numBer1} / {numBer2} = {div} ");
            Console.WriteLine("{0} / {1} = {2}", numBer1, numBer2, div);

            double multi = (double)numBer1 % numBer2;

            Console.WriteLine($"{numBer1} % {numBer2} = {multi} ");
            Console.WriteLine("{0} % {1} = {2}", numBer1, numBer2, multi);

            //double div = (double)numBer1 / numBer2;

            // Console.WriteLine($"{numBer1} / {numBer2} = {div.ToString("F2")}");
            //Console.WriteLine("{0} / {1} = {2}", numBer1, numBer2, div);



            // sum and average of 3 numbers: take user input

            int nuMber1, nuMber2, nuMber3, sum;
            double average;

            Console.Write("nuMber1 = ");
            nuMber1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("nuMber2 = ");
            nuMber2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("nuMber3 = ");
            nuMber3 = Convert.ToInt32(Console.ReadLine());


            sum = nuMber1 + nuMber2 + nuMber3;

            Console.WriteLine($"sum = {sum}");


            average = (double)sum / 3;

            Console.WriteLine($"average = {average.ToString("F2")}");

            // triangle area = 0.5 * base * height

            //double base, height;
            //  Console.WriteLine("Triangle area Calculation");

            // assingmen operator
            int ten = 20;

            ten += 5;

            Console.WriteLine($"ten = {ten}");

            ten -= 5;

            Console.WriteLine(ten);
            ten *= 5;

            Console.WriteLine($"ten = {ten}");

            #region relational/ comparision operators->true/false
            int five1 = 29;
            int five2 = 49;
            int five3 = 50;
            Console.WriteLine(five1 > five3);
            Console.WriteLine(five1 > five2);
            Console.WriteLine(five1 >= five3);
            Console.WriteLine(five1 <= five3);
            Console.WriteLine(five1 < five3);

            #endregion




            // logical operators

            int six1 = 30;
            int six2 = 45;
            int six3 = 54;

            Console.WriteLine(six3 > six1 && six2 > six1 && six2 < six3);


            Console.WriteLine(six3 > six1 || six2 < six1 || six2 < six3);

            Console.WriteLine(six3 < six1 || six2 < six1 || six2 > six3);


            #region unary operators-> +,-,++,--,
            int two = 10;
            Console.WriteLine(++two);   // pre increment-- sate sate valu barbe:11
            Console.WriteLine(two++);   // post increment-- one step por varbe11

            Console.WriteLine(++two);  // 11
            Console.WriteLine(two++);  //11
            Console.WriteLine(two--);  // 12
            Console.WriteLine(--two);  //10
            #endregion

            //condition statement 

            int con = 30;
            if (con > 0)
            {
                Console.WriteLine("positive Number");
            }
            else if (con < 0)
            {
                Console.WriteLine("negative numbers");
            }
            else if (con == 0)
            {
                Console.WriteLine("number zeroo");
            }

            //for loop

            for (int count = 1; count < 100; count = count + 2)
            {
                Console.WriteLine($"{count} : Count The Number 1-100");
            }

            int i = 1;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }


            /*int r = 100;
            do
            {
                Console.WriteLine("r");
                r++;
            }
            while (r < 10);
        }*/

            person p1 = new person();
            p1.Setvalu("asik",30);
            p1.PrintData();
         


            person p2 = new person();
            p2.Setvalu("Tamimi", 34);
            p2 .PrintData();






        }
    }
}


