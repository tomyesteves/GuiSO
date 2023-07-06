using Library.Classes;

namespace Program;

class Program {
    static void Main() {
        SystemHandler systemHandler = new();
        string ando = systemHandler.ListUsers();
        Console.WriteLine(ando);
        Console.ReadLine();
    }
}
