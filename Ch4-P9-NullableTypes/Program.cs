using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_P9_NullableTypes
{
    class DatabaseReader
    {
        // Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;
     
        // Note the nullable return type.
        public int? GetIntFromDatabase()
        { return numericValue; }
        
        // Note the nullable return type.
        public bool? GetBoolFromDatabase()
        { return boolValue; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  " Nullable types in C#  ");

            #region - Compiler Errors!

            //// Compiler errors!
            //// Value types cannot be set to null!
            //bool myBool = null;
            //int myInt = null;
            //// OK! Strings are reference types.
            //string myString = null;

            #endregion

            //LocalNullableVariables();

            //LocalNullableVariablesUsingNullable();

            #region Working with Nullable types

            //Console.WriteLine("***** Fun with Nullable Data *****\n");
            //DatabaseReader dr = new DatabaseReader();

            //// Get int from "database".
            //int? i = dr.GetIntFromDatabase();

            //if (i.HasValue)
            //    Console.WriteLine("Value of 'i' is: {0}", i.Value);
            //else
            //    Console.WriteLine("Value of 'i' is undefined.");

            //// Get bool from "database".
            //bool? b = dr.GetBoolFromDatabase();
            //if (b != null)
            //    Console.WriteLine("Value of 'b' is: {0}", b.Value);
            //else
            //    Console.WriteLine("Value of 'b' is undefined.");

            #endregion

            #region The Null Coalescing Operator

            //DatabaseReader dr = new DatabaseReader();

            //// If the value from GetIntFromDatabase() is null,
            //// assign local variable to 100.
            //int myData = dr.GetIntFromDatabase() ?? 100;
            //Console.WriteLine("Value of myData: {0}", myData);

            #endregion

            #region The Null Conditional Operator

            //TesterMethod(null);
            //TesterMethodforObjects(null);
            //TesterMethodforTypes(null);



            #endregion

            Console.ReadLine();

        }


        static void TesterMethodforTypes(List<int> list)
        {
            //Console.WriteLine($"You sent me {s?.Value} arguments.");
            Console.WriteLine($"You sent me {list?.Count} arguments.");
        }
        static void TesterMethodforObjects(string s)
        {

            Console.WriteLine($"You sent me {s?.Length} arguments.");
        }
        static void TesterMethod(string[] args)
        {
            //// We should check for null before accessing the array data!
            //if (args != null)
            //{
            //    Console.WriteLine($"You sent me {args.Length} arguments.");
            //}

                Console.WriteLine($"You sent me {args?.Length} arguments.");
        }

        private static void LocalNullableVariablesUsingNullable()
        {
            // Define some local nullable types using Nullable<T>.
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }

        private static void LocalNullableVariables()
        {
            // Define some local nullable variables.
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];
            
            // Error! Strings are reference types!
            // string? s = "oops";
        }
    }
}
