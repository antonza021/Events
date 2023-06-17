using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot();

            robot.Message += ReverseDirection; //Создание экземпляра класса Robot. Добавление обработчика события Message в виде метода ReverseDirection.

            for (int i = 0; i < 10; i++) robot.InitDirection(); //Цикл десяти итераций. В каждой итерации вызывается метод InitDirection у объекта класса Robot.

        }

        static void ReverseDirection() //Метод ReverseDirection, который записывает строку в файл
        {
            using StreamWriter sw = new StreamWriter(@"C:\Users\levch\OneDrive\Рабочий стол\log.txt", true, //Запись строки в файл log.txt с помощью StreamWrite. FileType.Append задает режим дозаписи в файл. Кодировка файла указывается как System.Text.Encoding.Default.
                System.Text.Encoding.Default);
            sw.WriteLine("Назад");
        }
    }
}
