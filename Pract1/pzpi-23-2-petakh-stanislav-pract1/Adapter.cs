namespace Client
{
    class Adapter : Target
    {
        Adaptee adaptee;
        
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void PrintHelloWorld()
        {
            adaptee.HelloWorld();
        }
    }
}