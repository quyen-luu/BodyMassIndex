public class Program
{
    private static void Main(string[] args)
    {
        //Chieu cao
        Console.Write("Input your height: ");
        bool isValidHeight = double.TryParse(Console.ReadLine(), out double height);
        if (!isValidHeight)
        {
            Console.WriteLine("Just enter the number!");
            return;
        }

        // Can nang
        Console.Write("Input your weight: ");
        bool isValidWeight = double.TryParse(Console.ReadLine(), out double weight);
        if (!isValidWeight)
        {
            Console.WriteLine("Just enter the number!");
            return;
        } 

        //Tính BMI
        double BMI = weight / Math.Pow(height, 2);
        BMI = Math.Round(BMI, 1);

        //Sử dụng if để hiển thị tình trạng BMI ra màn hình
        if (BMI < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (BMI < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (BMI < 30)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}