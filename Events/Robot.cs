using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Robot
    {
        public delegate void Direction(); //Определение нового типа делегата для события. Делегат Direction не принимает параметров и не возвращает значения

        public event Direction? Message; //Определение события Message с типом делегата Direction
        int GetDirection() => new Random().Next(5); //Определение метода GetDirection, который возвращает случайное число от 0 до 4

        public void InitDirection() //Метод InitDirection генерирует случайное число от 0 до 4 и вызывает событие Message при наличии подписчиков
        {
            switch (GetDirection())
            {
                case 0:
                    Message?.Invoke();
                    break;
                case 1:
                    Console.WriteLine("Вперёд");
                    break;
                case 2:
                    Console.WriteLine("Влево");
                    break;
                case 3:
                    Console.WriteLine("Вправо");
                    break; //Оператор switch проверяет значение, возвращаемое методом GetDirection().
                           //Если результат метода равен 0, генерируется событие Message. 
                           //В других случаях метод выдает на экран одну из строк: Вперед, Влево или Вправо.
            }
        }
    }
}
