using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Robot
    {
        public delegate void Direction();

        public event Direction? Message;
        int GetDirection() => new Random().Next(5);

        public void InitDirection()
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
                    break;
            }
        }
    }
}
