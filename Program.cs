using System;
namespace SampleApp
{
    class Person
    {
       public string Name { get; set; }
    }
    class Student : Person
    {
        public int Class { get; set; }
    }
    class SampleClass
    {
        public void PublicFunction()
        {
            Console.WriteLine("Accessible anywhere");
            PrivateFunction();
        }
        private void PrivateFunction() => Console.WriteLine("Accessible within the class");
        protected void ProtectedFunction() => Console.WriteLine("Accessible within family");
        public void InternalFunction() => Console.WriteLine("Accessible within Project");
        public void ProcInternalfunction() => Console.WriteLine("Accessible within Project or within the Family");
    }
    class DerivedClass : SampleClass
    {
        public void CallMyFunction()
        {
            ProtectedFunction();
        }
    }
    class OOPInheritance
    {
        static void Main(string[] args)
        {
            SampleClass cls = new SampleClass();
            cls.PublicFunction();
            cls = new DerivedClass();

            ((DerivedClass)cls).CallMyFunction();
            cls.ProcInternalfunction();
            cls.InternalFunction();
            




            //Student st =  new Student { Name = "Sree", Class = 10 };
            //Console.WriteLine("Name of the Student is{0}", st.Name);
            //Console.WriteLine("The student studying {0} class", st.Class);
        
        }
    }
}
