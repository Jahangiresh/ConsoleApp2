//int number = Convert.ToInt32(Console.ReadLine());
//int[] num = new int[0];
//int index = 0;
//if (number < 50)
//{
//    for (int i = 3; i <= number; i+=3)
//    {
//        if (number % 3 ==0)
//        {

//            index++;
//            Console.WriteLine(i);

//        }
//    }
//}
//if (number > 50 && number < 100)
//{
//    for (int i = 5; i <= number; i += 5)
//    {
//        if (number % 5 == 0)
//        {

//            index++;
//            Console.WriteLine(i);
//        }
//    }
//}
//if (number > 100)
//{
//    for (int i = 8; i <= number; i += 8)
//    {
//        if (number % 8 == 0)
//        {

//            index++;
//            Console.WriteLine(i);
//        }
//    }
//}
//string[] animals = { "snake", "lion", "bird", "tiger", "elephant" };
//foreach (string animal in animals)
//{
//    if (animal.Length < 5)
//    {
//        Console.WriteLine(animal);
//    }
//}

int num =Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num > 0)
{
    sum += num % 10;
    num = num / 10;
}
Console.WriteLine(sum);