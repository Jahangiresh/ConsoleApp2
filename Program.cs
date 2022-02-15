namespace TetsForMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] grades = { 70, 65, 100, 90, 30, 95, 40 };
            int studs;
            int result = subs(grades, out studs);
            int orta = average(result, studs);
            Console.WriteLine(orta);


        }
        public static int subs(int[] grades, out int studs)
        {
            int result = 0;
            studs = grades.Length;

            foreach (int grade in grades)
            {
                result += grade;

            }
            return result;
        }
        public static int average(int result, int studs)
        {
            int orta = result / studs;
            return orta;


        }

    }
}
