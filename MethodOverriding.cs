using System;
namespace SampleApp
{
    class Parent
    {
        public void NonvFunc() => Console.WriteLine("Don't expect to be modified");
        public virtual void TestFunc() => Console.WriteLine("test Func from Base");
    }
    class Child : Parent
    {
        public override void TestFunc()
        {
            Console.WriteLine("Test Func modified in the derived");
        }
    }
    static class ParentFactory
    {
        public static Parent GetObject(string name)
        {
            Parent obj = null;
            if (name.ToLower() == "parent")
                obj = new Parent();
            else
                obj = new Child();
            return obj;

        }
    }
    class MethodOverriding
    {
        static void Main(string[] args)
        {
            //Parent obj = new Parent();
            //obj.TestFunc();

            //obj = new Child();
            //obj.TestFunc();

            Console.WriteLine("tell me which class U want Parent or Child");
            string className = Console.ReadLine();

            Parent obj = ParentFactory.GetObject(className);
            obj.TestFunc();



        }
    }
}
