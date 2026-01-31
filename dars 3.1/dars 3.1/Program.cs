namespace dars_3._1;

internal class Program
{
    static void Main(string[] args)
    {
        MyList myList = new MyList(3);
        myList.Add(77);
        myList.Add(71);
        myList.Add(73);
        Console.WriteLine(myList.Capacity);
        myList.Remove(71);
        myList.Add(11);
        Console.WriteLine(myList.Capacity);
        myList.DisplayElements();
    }
}
