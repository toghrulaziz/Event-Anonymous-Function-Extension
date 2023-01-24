public delegate void Func(string s);


class MyClass
{
    public string Str { get; set; }

    public MyClass(string str)
    {
        Str = str;
    }

    public void Space(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + "_");
        }
        Console.WriteLine("\n");
    }

    public void Reverse(string str)
    {
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
    }

}


class Run
{
    public void runFunc(Func del, string arg)
    {
        del.Invoke(arg);
    }
}


namespace EventTaskCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            var str = Console.ReadLine();

            MyClass cls = new MyClass(str);

            Func funcdell = new Func(cls.Space);
            funcdell += cls.Reverse;

            Run run = new Run();
            run.runFunc(funcdell, str);
            
        }
    }
}
