using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Shet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // короче создаешь этот проект и проект модульного теста. Главное не забыть правой кнопкой мыши нажать в обозревателе решений на тестовый проект и добавить ссылку на основной проект
            // а дальше просто юзинг -- название основного проекта -- и инициализировать класс
            TextWriterTraceListener[] listeners = new TextWriterTraceListener[] 
            {
            new TextWriterTraceListener("C:\\Users\\zelen\\Desktop\\Подготовка к экзамену\\Программы\\pop.txt"),
            new TextWriterTraceListener(Console.Out)
            };
            Debug.Listeners.AddRange(listeners);
            Debug.WriteLine("Some Value", "Some Category");
            Debug.Flush();

        }
    }
    public class Plus
    { 
        public int sum(int a, int b)
        { return a + b; }
        public static void ReadStudents()
        {
            StreamReader students = new StreamReader(@"C:\Users\zelen\Desktop\ElectronicGradeBook\ElectronicGradeBook\\students.txt");

            string line = students.ReadLine();
            string[] start = { "ФИО студента", "Год зачисления", "Форма обучения", "Специальность" };
            string table = start[0];
            int i = 0;

            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"----------------",15}----|-{$"---------------",15}-|");
            Console.WriteLine($"|{$"{"№"}",2} | {$"{start[0]}",35}     | {$"{start[1]}",15}     | {$"{start[2]}",15}     | {$"{start[3]}",15} |");
            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"----------------",15}----|-{$"---------------",15}-|");

            while (line != null)
            {
                i++;
                string[] splitLine = line.Split(';');
                string fio = splitLine[0];

                Console.WriteLine($"|{$"{i}",2} | {$"{splitLine[0]}",35}     | {$"{splitLine[1]}",15}     | {$"{splitLine[2]}",15}     | {$"{splitLine[3]}",15} |");
                Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"----------------",15}----|-{$"---------------",15}-|");

                line = students.ReadLine();
            }
            students.Close();
        }

        public static void PlusStudents(string[] DataPlus)
        {
            StreamWriter students = new StreamWriter(@"C:\Users\zelen\Desktop\ElectronicGradeBook\ElectronicGradeBook\\students.txt", append: true);

            string line = $"{DataPlus[0]};{DataPlus[1]};{DataPlus[2]};{DataPlus[3]}";

            students.WriteLine(line);
            students.Close();
        }
    }
}
