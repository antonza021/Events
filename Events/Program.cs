using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot();

            robot.Message += ReverseDirection;

            for (int i = 0; i < 10; i++) robot.InitDirection();
        }

        static void ReverseDirection()
        {
            using StreamWriter sw = new StreamWriter(@"C:\Users\levch\OneDrive\Рабочий стол\log.txt", true,
                System.Text.Encoding.Default);
            sw.WriteLine("Назад");
        }
    }
}
