using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Task66
{
    /*Условие:
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте программу, в которой создайте класс хвост, который содержит в себе поля длину хвоста 
    типа int и вид хвоста типа string, создать свойства доступа и конструктор пользовательский 
    класса. Создать класс хвостатое животное, содержащий хвост, цвет(строка), возраст. Определить 
    public - производный класс собака, имеющий дополнительный параметр-кличку (строка). 
    В классе собака создать метод для отображения полной информации о собаке.*/

    class Tail
    {
        public int tailLength { get; set; }// Поле класса
        public string tailView { get; set; } // Поле класса
        public Tail(int newTailLength, string newTailView) // Конструктор
        {
            tailLength = newTailLength;
            tailView = newTailView;
        }
    }
     class TailedAnimal
     {
        public Tail myTailLength = new Tail(45, "Длинный"); // Класс хвост
        public int age { get; set; } // Поле класса
        public string tailColor { get; set; } // Поле класса  
     }
    class Dog : TailedAnimal // Производный класс собака
    {
        public string nickname { get; set; } // Поле класса
        public void infoDog() // Метод вывода полной информации
        {
            int length = myTailLength.tailLength; // Данные слассла хвост в классе хвостатые животные
            string view = myTailLength.tailView;  // Данные слассла хвост в классе хвостатые животные           
            Console.WriteLine($"Кличка:        {nickname}");
            Console.WriteLine($"Возраст:       {age} лет");
            Console.WriteLine($"Цвет:          {tailColor}");
            Console.WriteLine($"Длинна хвоста: {length} см");
            Console.WriteLine($"Вид воста:     {view}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();            
            myDog.nickname = "Шарик";
            myDog.age = 15;
            myDog.tailColor = "Черный";
            myDog.infoDog(); // Метод вывода полной информации
            Console.ReadKey();
        }
    }
}
