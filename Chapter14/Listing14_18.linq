<Query Kind="Program" />

void Main()
{
    object text = "text";
    dynamic d = 10;
    Execute(d, text);    
}

static void Execute(dynamic x, string y)
{
    Console.WriteLine("dynamic, string");
}

static void Execute(dynamic x, object y)
{
    Console.WriteLine("dynamic, object");
}
