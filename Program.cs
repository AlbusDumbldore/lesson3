namespace ObjectStudent
{
    internal class Program
    {
        static void Main()
        {
            Student student1 = new Student();
            student1.Health = 100;
            student1.Intellect = 100;
            student1.Happy = 100;
            student1.Knowledge = 100;
            Console.WriteLine($"Студент Сергей. Базовые характеристики: Здоровье - {student1.Health}, Интеллект - {student1.Intellect}, Счастье - {student1.Happy}, Знания - {student1.Knowledge}");

            Console.WriteLine("Введите действие:");
            string order = Console.ReadLine();
            while (order != "Спать!")
            {
                if (order == "Веселье")
                {
                    student1.Fun();
                }

                else if (order == "Учёба")
                {
                    student1.Study();
                }

                else if (order == "Экзамен")
                {
                    student1.Exams();
                }
                else
                {
                    Console.WriteLine("Неверное действие");
                }
                Console.WriteLine("Введите дейтсвие:");
                order = Console.ReadLine();
            }
        }
    }

    internal class Student
    {
        public int Health;
        public int Intellect;
        public int Happy;
        public int Knowledge;

       public void Fun()
        {
            Knowledge = 100 - 35;
            Happy = 100 + 20;
            Intellect =100 - 5;
            Health = 100;
            Console.WriteLine($"Студент Сергей: Здоровье - {Health}, Интеллект - {Intellect}, Счастье - {Happy}, Знания - {Knowledge}");
        }
        public void Study()
        {
            Knowledge = 100 + 10;
            Happy = 100 - 30;
            Intellect = 100 + 2;
            Health = 100 - 5;
            Console.WriteLine($"Студент Сергей: Здоровье - {Health}, Интеллект - {Intellect}, Счастье - {Happy}, Знания - {Knowledge}");
        }

        public void Exams()
        {
            Knowledge = 100 - 6;
            Happy = 100 - 50;
            Intellect = 100;
            Health = 100 - 20;
            Console.WriteLine($"Студент Сергей: Здоровье - {Health}, Интеллект - {Intellect}, Счастье - {Happy}, Знания - {Knowledge}");
        }
    }
}