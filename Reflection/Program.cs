using Reflection;
using System.Reflection;

Type type = typeof(MyClass);
Console.WriteLine("Class: " + type.Name);

MethodInfo[] methods = type.GetMethods();
foreach (var method in methods)
{
    Console.WriteLine("Method: " + method.Name);
}