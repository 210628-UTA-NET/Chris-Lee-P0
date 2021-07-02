using System; //importing system namespace
            //equivalent to Java "packages"
using HouseFunction;
/*
    Naming conventions in C#
    -use PascalCase for most naming convention
    -use camelCase for naming fields
*/

namespace HelloWord
{
    class Program
    {
            //can use underscores for private fields to reference them more easily in our code
            private static string _first = "Hello";
            private static string _last = "World!";
        

        //  -static means you don't have to instantiate the program class to use that method
        static void Main(string[] args)
        {
            Console.WriteLine("Anything I want!");
            
            Test obj = new Test();
            obj.SomeMethod();

            Console.WriteLine(_first + _last);
            Console.WriteLine(object.SomeMethod());

            House objHouse = new House();

    }


}
    class Test
    {
        public string SomeMethod()
        {
            return "Hello World SomeMethod.";
        }
    }