using System;

namespace Pesochnica {
        class Program {
            static void Main(string[] args) {

            Console.WriteLine("Введите количество друзей: ");
            int N;
            while (!int.TryParse(Console.ReadLine(), out N) || N<0) {
                Console.WriteLine("Число введено неверно, повторите попытку");
            }
            int[] friends = new int [N]; // заполнение массива друзей
            for (int i = 0; i < N; i++) {
                friends[i] = i + 1; 
            }

            Console.WriteLine("Введите количество роллов: ");
            int T;
            while (!int.TryParse(Console.ReadLine(), out T) || T<0) {
                Console.WriteLine("Число введено неверно, повторите попытку");
            }
            int[] rolls = new int[T]; // заполнение массива с роллами
            for (int i=0; i<T; i++) {
                rolls[i] = i + 1; 
            }

        }
    }
}
