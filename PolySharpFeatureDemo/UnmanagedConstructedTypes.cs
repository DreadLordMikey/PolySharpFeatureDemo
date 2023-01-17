using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolySharpFeatures
{
    // See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint
    //
    // The unmanaged generic type constraint requires that a type argument must be a non-nullable value type, along
    // with all fields at any level of nesting, in order to use it as a parameter.
    internal class UnmanagedConstructedTypes
    {
        public static void Execute()
        {
            ConstraintWithClass();
            ConstraintWithStruct();
            ConstraintWithEnum();
            ConstraintWithDateTime();
            ConstraintWithNumberTypes();
        }

        private static void ConstraintWithClass()
        {
            Debug.WriteLine("UnmanagedConstructedTypes.ConstraintWithClass\n");

            //var instance = new A();
            //Foo(instance); // Compile-time error: instance is not non-nullable value type.

            Debug.WriteLine("var instance = new A(); // A is a class");
            Debug.WriteLine("Foo(instance); // Compile-time error: instance is not non-nullable value type.");

            Debug.WriteLine("");
        }

        private static void ConstraintWithStruct()
        {
            Debug.WriteLine("UnmanagedConstructedTypes.ConstraintWithStruct\n");
            var instance = new B();
            var result = Foo(instance); // Works because B is a struct with no reference type members.

            Debug.WriteLine("var instance = new B(); // B is a struct");
            Debug.WriteLine("var result = Foo(instance);");
            Debug.WriteLine($"result: {result}\n");
        }

        private static void ConstraintWithEnum() 
        {
            Debug.WriteLine("UnmanagedConstructedTypes.ConstraintWithEnum\n");
            var result = Foo(ConsoleColor.Red); // Works.
            Debug.WriteLine("var result = Foo(ConsoleColor.Red);");
            Debug.WriteLine($"result: {result}\n");
        }

        private static void ConstraintWithDateTime()
        {
            Debug.WriteLine("UnmanagedConstructedTypes.ConstraintWithDateTime\n");
            var result = Foo(DateTime.Now);
            Debug.WriteLine("var result = Foo(DateTime.Now);");
            Debug.WriteLine($"result: {result}\n");
        }

        private static void ConstraintWithNumberTypes()
        {
            Debug.WriteLine("UnmanagedConstructedTypes.ConstraintWithNumberTypes\n");
            var bResult = Foo(byte.MaxValue);
            Debug.WriteLine("var result = Foo(byte.MaxValue);");
            Debug.WriteLine($"result: {bResult}\n");

            var sResult = Foo(short.MaxValue);
            Debug.WriteLine("var result = Foo(short.MaxValue);");
            Debug.WriteLine($"result: {sResult}\n");

            var iResult = Foo(int.MaxValue);
            Debug.WriteLine("var result = Foo(int.MaxValue);");
            Debug.WriteLine($"result: {iResult}\n");

            var lResult = Foo(long.MaxValue);
            Debug.WriteLine("var result = Foo(long.MaxValue);");
            Debug.WriteLine($"result: {lResult}\n");

            var mResult = Foo(decimal.MaxValue);
            Debug.WriteLine("var result = Foo(decimal.MaxValue);");
            Debug.WriteLine($"result: {mResult}\n");

            var fResult = Foo(float.MaxValue);
            Debug.WriteLine("var result = Foo(float.MaxValue);");
            Debug.WriteLine($"result: {fResult}\n");

            var dResult = Foo(double.MaxValue);
            Debug.WriteLine("var result = Foo(double.MaxValue);");
            Debug.WriteLine($"result: {dResult}\n");
        }

        private static T Foo<T>(T bar) where T : unmanaged
        {
            return bar;
        }

        private class A 
        { 
            public int X { get; set; }
            public int Y { get; set; }
        }

        private struct B 
        {
            public int X;
            public int Y;

            public override string ToString()
            {
                return $"X: {X}, Y: {Y}";
            }
        }
    }


}
