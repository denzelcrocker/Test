using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
    }
}
