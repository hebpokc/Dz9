using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1");
            Console.WriteLine("Программа реализует класс Cipher и интерфейс ICipher, которые зашифровывают и дешифровывают текст");
            Console.Write("\nВведите текст для ACipher: ");
            string text = Console.ReadLine();

            ACipher ciphA = new ACipher(text);
            Console.WriteLine("\nЗашифрованный текст: " + ciphA.Encode());
            Console.WriteLine("Дешифрованный текст: " + ciphA.Decode());

            Console.Write("\nВведите текст для BCipher: ");
            text = Console.ReadLine();
            BCipher ciphB = new BCipher(text);
            Console.WriteLine("\nЗашифрованный текст: " + ciphB.Encode());
            Console.WriteLine("Дешифрованный текст: " + ciphB.Decode());

            Console.WriteLine("\nДом. задание 10.1");
            Console.WriteLine("Программа реализует классы геом. фигур");

            Point point = new Point(Colors.Черный, true);
            point.HorizCoordinate = 5;
            point.VertCoordinate = -2;
            point.Print();

            Console.WriteLine("\nИзменение координат");
            point.MoveHorizontal(4);
            point.MoveVertical(3);
            point.Print();

            Circle circle = new Circle(6, Colors.Синий, false);
            circle.Print();

            Console.WriteLine("\nИзменение цвета");
            circle.ChangeColor(Colors.Красный);
            circle.Print();

            Rectangle rectangle = new Rectangle(4, 9, Colors.Фиолетовый, true);
            rectangle.Print();

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
