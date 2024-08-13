using System.Text;

namespace session_1_linq
{
    internal class Program
    {
        static dynamic print(dynamic obj) { 
        return obj;
        
        }
      
        static void Main(string[] args)
        {
            #region var and dynamic

            //var x=12;
            //var y = null;
            //x = "ahmed";
            //cant change Datatype of local variablle after Initialization
            // invalid to use var with function

            // Dynamic
            //dynamic x2 = "Ahmed";//like var in js
            //x2 = 5;
            //x2 = new StringBuilder("ahmed");
            //x2 = 1.9;
            ////Dont need to be initialized
            //dynamic x;
            //x = 12;
            //Console.WriteLine(x);
            //can change datatype pf local variable after initialization
            //dynamic Data01 = 12;
            //Data01 = "bassim";
            //Console.WriteLine(Data01.GetType().Name);
            //dynamic x=print(Data01);
            //Console.WriteLine(x);
            #endregion
            #region extension methods
            int number = 1234;
            //var result=IntExtension.Reverse(number);
            //Console.WriteLine(result);
           
            Console.WriteLine(number.Reverse());
            #endregion
            #region  Annoymous Types
            var Emp01 = new { id = 1, name = "bassim", salary = 22 };
            Console.WriteLine(Emp01);
            var Emp02 = new { id = 1, name = "bassim", salary = 22 };
            Console.WriteLine(Emp01.GetType().Name);
            Console.WriteLine(Emp02.GetType().Name);
            //not allow to set value 
            //Emp01.id = 12;
            if (Emp01.Equals(Emp02)) {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            #endregion
            #region whats linq
            List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9 };
         var result= Enumerable.Where(list, N => N % 2 == 0);
            foreach (var item in result) {

                Console.WriteLine(item);
            }
            #endregion
            #region Linq syntax
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //var output=Enumerable.Where(Numbers,N=> N % 2 == 0);
            //foreach (var item in output) {
            //    Console.WriteLine(item);
            //}

            //querty syntax
            //var output=from N in Numbers
            //           where N % 2 == 0
            //           select N;
            //foreach (var item in output)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion





        }
    }
}
