using System;
using System.Reflection;
using System.Linq;

namespace Lab6
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor)]
    public class WriteAttribute : Attribute { }

    public delegate string Concat(int x, double y);

    public class SampleClass
    {
        [Write]
        public int SampleField { get; set; }

        public double SampleField1 { get; set; }

        public SampleClass(int parameter, double parameter1) =>
            (SampleField, SampleField1) = (parameter, parameter1);

        [Write]
        public SampleClass(int parameter) : this(parameter, parameter) { }

        public void Write() =>
            Console.WriteLine($"{SampleField}; {SampleField1}");

        [Write]
        public double Add(int value) => SampleField + SampleField1 + value;
    }

    public static class Program
    {
        public static string ConcatTogether(int x, double y) =>
            $"{x}{y}";

        public static void Write(Concat concat) =>
            Console.WriteLine(concat(15, 3.45d));

        public static void Write(Func<int, double, string> concat) =>
            Console.WriteLine(concat(10, 2.71d));

        public static void WriteMember(MemberInfo info)
        {
            if (info.GetCustomAttribute(typeof(WriteAttribute)) != null)
                Console.WriteLine(info);
        }

        public static void Main()
        {
            Console.WriteLine(nameof(Concat));
            Write(new Concat(ConcatTogether));
            Write(new Concat((x, y) => $"{x}; {y}"));

            Console.WriteLine(nameof(Func<int, double, string>));
            Write(new Func<int, double, string>(ConcatTogether));
            Write(new Func<int, double, string>((x, y) => $"{x} {y}"));

            Console.WriteLine("Reflection");
            var type = typeof(SampleClass);

            foreach (var constructor in type.GetConstructors())
                WriteMember(constructor);

            foreach (var property in type.GetProperties())
                WriteMember(property);

            foreach (var method in type.GetMethods())
                WriteMember(method);

            var sampleClass = new SampleClass(4);
            Console.WriteLine(typeof(SampleClass).GetMethod("Add").Invoke(sampleClass, new object[] { 3 }));
        }
    }
}
