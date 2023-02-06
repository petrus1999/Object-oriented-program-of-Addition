using Object_oriented_program_of_Addition;
class Program {
    static void Main(string[] args)
    {
        Test_data dataClass = new Test_data();
        int add2 = dataClass.Add(45, 34, 67);
        int add1 = dataClass.Add(23, 34);
        Console.WriteLine(add1);
        Console.WriteLine(add2);

    }
}
