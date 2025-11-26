namespace Example4
{
    public class DerivedClass : AbstractExample
    {
        // Hereda ExtraAttribute de la clase abstracta

        public override void DoSomething()
        {
            Console.WriteLine("Haciendo algo en Derived4");
        }
    }
}