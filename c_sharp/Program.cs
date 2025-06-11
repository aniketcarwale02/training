using System ;
using System.Linq ;// more functions

// inbuilt system namespace(folder basically)
// ignore blank line
namespace cSharpBasics
{
    class Program {   // named grp of properties and funtion
      
        static void greet(out string gender, string name="aniket"){
        // Optional parameters must appear after all required parameters
          gender = "male";
          Console.WriteLine($"Good Morning {name}");
        }

        static void Main(string[] args){
            // Console class se WriteLine function use kiya
            Console.WriteLine("hello world");
            string gender ;
            // if ref used initial value must be set : gender = "girl"
            greet(out gender);
            greet(out gender,"ayush");
            Console.WriteLine(gender);

            // variables 
            /*Types of variables
            · int - stores integers (whole numbers), without decimals, such as
               123 or -123
            · double - stores floating point numbers, with decimals, such as
               19.99 or -19.99
            · char - stores single characters, such as 'a' or 'B'.
            . string - stores text, such as "Hello World".
            . bool - stores values with two states: true or false*/

            string name = "aniket";
            int a =10;
            Console.WriteLine(name+" "+a);

            // const int b =  10;
            // b = 20 ; error 

            // Naming Variables
            //     · Names can contain letters, digits and the underscore
            //     character (_)
            //     . Names must begin with a letter
            //     . Names should start with a lowercase letter and it cannot
            //     contain whitespace
            //     · Names are case sensitive ("a" and "A" are different
            //     variables)
            //     . Reserved words (like C# keywords, such as static, void
            //     string or const) cannot be used as names
            //     int 4byte, long 8byte, float 6-7 digit after ., decimal 15 digit after ., string "a" , char 'a' , bool false/true

            // implicit : automatic (smaller to larger type)
            // char,int,long,float,double

            // int i = 10;
            // double d = i;
            // Console.WriteLine(d);

            // Explicit casting (manually) : big to small size
            double i = 10.234;
            int d = (int)i;
            Console.WriteLine(d);
            // base = child (allowed)//upcasting  , child = (child) base    (explicitly mention krna padega)
            // Child ch = b as Child;   or use if and is (b is Child ch)
            // if (ch != null)
            // {
            //     // Safe to use
            // }

           /* Type Conversion Methods
                Convert.ToBoolean
                Convert.ToFloat
                Convert.ToDouble
                Convert.ToChar
                Convert.ToString or ToString
                Convert.ToInt32 (int)
                Convert.ToInt64 (long)
                */

            Console.WriteLine("Enter age :");
            int age = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine(age);
                        
            // Arithematic Operator : +,-,*,/,%,increment(++),decrement(--)
            // assignment Operator : =,+=,-=,*=,/=,%=
            // Math. : Max , Min , Sqrt , Abs , Round , Floor , Ceiling 
            // string fn : Length , ToUpper() ToLower() , Concat(first,Second) or + , interpolation $"hii {} and {}" ,for specific chara [i] , NOT MODIFY OF STRING (IMMUTABLE) greet[0] = 'b' wrong, IndexOf("")
            // Substring : Substring(index)
            // escape chara " hi \"c-sharp\" p "
            // bool exp : ==,>,<,>=,<=
            // logical op : && , || , ! ,
            // flow control : if-else if-else,(single variable comparison)switch(case) : case 1: break;
            // loops : while ,  do-while , for(initialize , condition , increment) , break;continue;

            string[] cars = {"volvo" ,"BMW" , "maruti"};
            string[] car2 = new string[4];
             Console.WriteLine(car2[0]);//blank
            //cars.length
            foreach(string str in cars){
                Console.WriteLine(str);
            }
            //sorting : Arrays.Sort(cars)

            //Linq : arr.Max(),arr.Min(),arr.Sum()

            //Exception handling (try catch finally)
            // child exception above and parent exception below
            try
            {
                cars[4] = "hi"; // This will throw IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
                
                // Optional: rethrow
                // throw;              // Rethrow same exception
                // throw new Exception("Custom message", ex); // Wrap in a new exception
            }
            catch (ArgumentException ex){
                Console.WriteLine("Exception Message of argument: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
            }
            catch (Exception ex){
                Console.WriteLine("Exception Message of argument: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
            }
            
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.WriteLine("Program continues...");




        }
    }
    
}