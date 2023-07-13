namespace exercises;

class Program
{
    static void Main(string[] args)
    {   //zd 19

        int Input(string text){
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        int num = Input("Введите число пятизначное число: ");
        int a = num / 1000;
        int b = num % 100;
        
        if (a / 10 == b % 10 && a % 10 == b / 10){
            Console.WriteLine("Ваше число - полиндром");
        }
        else {
            Console.WriteLine("Ваше число - не полиндром");
        }
       
        

        //zd 21
        // int x1 = Input("Bведите х1: ");
        // int y1 = Input("Введите y1: ");
        // int z1 = Input("Введите z1: ");
        // int x2 = Input("Bведите х2: ");
        // int y2 = Input("Введите y2: ");
        // int z2 = Input("Введите z2: ");
        // double dist = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
        // dist = Math.Round(dist, 2);
        // Console.WriteLine($"расстояние между точками равно: {dist}");

        //zd 23
        
        // int num = Input("Ваедите число: ");
        // for (int i = 1; i <= num; i++){
        //     Console.WriteLine($"{i}^3 = {i*i*i}");
        //}
    }
}
