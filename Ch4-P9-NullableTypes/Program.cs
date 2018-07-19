using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_P9_NullableTypes
{
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

            Console.ReadLine();
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
