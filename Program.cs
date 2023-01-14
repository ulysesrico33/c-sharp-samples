// See https://aka.ms/new-console-template for more information
using System.Dynamic;

namespace HelloWorld
{
class Sample 
{

    public string MyProperty1 { get; set; }
    public string MyProperty2 { get; set; }
     
    
}
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of class Sample
            Console.Write("Sample class");
            Console.WriteLine("-------------------------------------------------");
            Sample oSample = new Sample();

            oSample.MyProperty1 = "value1";
            oSample.MyProperty2 = "value2";

            Console.WriteLine($"Prop1 is : {oSample.MyProperty1}");
            Console.WriteLine($"Prop2 is : {oSample.MyProperty2}");

            // Way 1 : Create a dynamic object

            Console.Write("First way to set properties in Dynamic object");
            Console.WriteLine("-------------------------------------------------");

            dynamic oDynamic = new ExpandoObject();
            oDynamic.prop1="hello";
            oDynamic.prop2="hello2";

            Console.WriteLine($"Dynamic Prop1 is : {oDynamic.prop1}");
            Console.WriteLine($"Dynamic Prop1 is : {oDynamic.prop2}");

            // Way 2 : Create a dynamic object as dictionary

            Console.Write("Adding properties with dynamic object with IDictionary");
            Console.WriteLine("-------------------------------------------------");

            var oDynamicDic = new ExpandoObject() as IDictionary<string,object>;
            var anything="One";
            var prop1=$"property{anything}";
            oDynamicDic.Add(prop1,"I am prop1 in a Dictionary");

            Console.WriteLine($"DynamicDic Prop1 is : {oDynamicDic["propertyOne"]}");
            
        }
    }
}