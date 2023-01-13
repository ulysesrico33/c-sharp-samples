// See https://aka.ms/new-console-template for more information

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
            Sample oSample = new Sample();

            oSample.MyProperty1 = "value1";
            oSample.MyProperty2 = "value2";

            Console.WriteLine($"Prop1 is : {oSample.MyProperty1}");
            Console.WriteLine($"Prop1 is : {oSample.MyProperty2}");

            // Way 1 : Create a dynamic object

            dynamic oDynamic = new System.Dynamic.ExpandoObject();
            oDynamic.prop1="hello";
            oDynamic.prop2="hello2";

            Console.WriteLine($"Dynamic Prop1 is : {oDynamic.prop1}");
            Console.WriteLine($"Dynamic Prop1 is : {oDynamic.prop2}");

            // Way 2 : Create a dynamic object as dictionary

            var oDynamicDic = new System.Dynamic.ExpandoObject() as IDictionary<string,string>;
            oDynamicDic.Add("prop1","hello");

            Console.WriteLine($"DynamicDic Prop1 is : {oDynamicDic.prop1}");
            
        }
    }
}