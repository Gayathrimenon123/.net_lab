
namespace ConsoleApp1
{
    /*abstract class AbsMethod
    {
        public int x;
        public abstract void add(); //abstract method
        public virtual void disp() 
        {
            Console.WriteLine("Parent Class");
        }
    }*/
    class Parent
    {
        public virtual void disp()
        {
            Console.WriteLine("Parent Class");
        }
    }
    class Inh : Parent
    {
        public override void disp()
        {
            Console.WriteLine("Child Class");
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Parent i = new Inh();
            //i.add();
            i.disp();
            i=new Parent();
            i.disp();
        }
    }
}