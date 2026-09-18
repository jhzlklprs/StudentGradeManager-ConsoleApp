namespace StudentGradeManager_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Student Grade Manager Console App!");

            string select = "";

            while (select != "5")
            {

                Menu();

                Console.WriteLine("Select:");
                select = Console.ReadLine();



            }
            Console.WriteLine("GoodBye!");

            Dictionary<string, int> students = new Dictionary<string, int>();

            Console.WriteLine("Please Enter student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter student age: ");
            int age = int.Parse(Console.ReadLine());

            Action<string, int> AddStudent = (name, age) => students.Add(name, age);

            switch (select)
            {
                case "1":
                    Console.WriteLine("You selected 1");

                    break;
                default:
                    break;
            }
        }

        static void Menu()
        {
            Console.WriteLine("   1. Add student\r\n   2. View all students\r\n   3. Update a grade\r\n   4. Delete a student\r\n   5. Exit");
        }

        


}
}
