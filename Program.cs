namespace ConsoleApp6
{
    class Program
    {
        public static void Main(string[] args)
        {
            ;

            Console.WriteLine("write student fullname");
            Student student = new Student();

            Console.WriteLine("qrup adi");
            student.groupno = Console.ReadLine();

            Console.WriteLine(student.GroupNo);


        }
    }
}