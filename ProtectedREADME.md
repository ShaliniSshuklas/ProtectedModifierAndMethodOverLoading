using System;

namespace ProtectedModifier
{
    public class FirstClass
    {
         protected int unitId;
         protected string unitValue;

        public FirstClass(int id)
        {
            this.unitId = id;
        }

        public FirstClass(int id, string value)
        {
            this.unitId = id;
            this.unitValue = value;
        }
    }

    public class SecondClass: FirstClass
    {
        public SecondClass(): base(12)
        {
                
        }
        public void main()
        {
            SecondClass secondClass = new SecondClass();

            secondClass.unitId = 12;
            Console.WriteLine(unitId);

            base.unitId = 13;
            Console.WriteLine(unitId);

            this.unitId = 14;
        }
    }

    public class Program 
    {
        static void Main(string[] args)
        {
            SecondClass obj = new SecondClass();
            obj.main();
        }
    }
}
