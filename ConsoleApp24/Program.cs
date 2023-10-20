//int x = 1000000000;
//short y = 10000;
//long z = 1000000000000000000;
//double d = 5.5;
//float f = 1.0f;
//string s = "text";
//char c = '%';
//bool truth = true;



//Console.WriteLine("Введите длину:");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите ширину:");
//double b = double.Parse(Console.ReadLine());
//double result;
//result = (a + b) * 2;
//Console.WriteLine($"Периметр равен: {result}," +
//    $" при длине {a} и ширине {b}");

/*
string fname = Console.ReadLine();
string sname = Console.ReadLine();
string result2;
result2 = fname + sname;
Console.WriteLine(result2);
*/


//result = a + b;
//result = a - b;
//result = a * b;
//result = a / b;
//result = a % b;

//int a = 9;

/*
double.TryParse(Console.ReadLine(), out double a);
double.TryParse(Console.ReadLine(), out double b);
double.TryParse(Console.ReadLine(), out double c);

double result = (b + Math.Sqrt(Math.Pow(b, 2) +
    4 * a * c)) / (2 * a) - Math.Pow(a, 3) * c
    + Math.Pow(b, -2);
Console.WriteLine(result);
*/

// Рисование примитивами
// Graphics
// Средства - Диспетчер пакетов Nuget - Управление пакетами...
// ищем Graphics и устанавливаем пакет System.Drawing.Common
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ConsoleApp18
{
    partial class Program
    {
        static void Main(string[] args)
        {

            Graphics graphics;
            Console.ReadLine();
            // инициализация Graphics выполняется через методы на классе
            graphics = Graphics.FromHwnd(Process.GetCurrentProcess().
                MainWindowHandle);

            // методы, начинающиеся на Draw - рисуют контуры, для рисования
            // используется ручка (Pen)
            // методы, начинающиеся на Fill - заливка, для рисования
            // используется кисть (SolidBrush, LinearGradientBrush, TextureBrush)
            // цвета используются через класс Color
            Pen pen = new Pen(Color.Red, 2); // красная ручка, толщиной 2px
            //graphics.DrawEllipse(pen, 100, 100, 30, 30);// 10 - X и Y, 30 - длина
            //graphics.DrawLine(pen, 100, 100, 150, 150);     // и ширина

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(100, 100, 30, 30);
            Rectangle rectangle = new Rectangle {  X = 100, Y = 100,
             Height = 100, Width = 100};
            graphicsPath.AddRectangle(rectangle);
            graphics.DrawPath(pen, graphicsPath);

            graphics.DrawBezier(pen, 100, 100, 150, 150, 200, 100, 250, 150);

            graphics.DrawCurve(pen, new Point[] {
                new Point(100, 100),
                new Point(150, 150),
                new Point(200, 150),
                new Point(250, 100),
                new Point(255, 400)
            });
            pen.Color = Color.White;
            graphics.DrawLines(pen, new Point[] {
                new Point(100, 100),
                new Point(150, 150),
                new Point(200, 150),
                new Point(250, 100),
                new Point(255, 400)
            });

            graphics.FillClosedCurve(Brushes.PaleVioletRed, new Point[] {
                new Point(100, 100),
                new Point(150, 150),
                new Point(200, 150),
                new Point(250, 100),
                new Point(255, 400)
            });

            SolidBrush solidBrush = new SolidBrush(
                Color.FromArgb(255, 10, 100));
            

            LinearGradientBrush linearGradientBrush =
                new LinearGradientBrush(new PointF(0, 0),
                 new PointF(100, 100), Color.Blue,
                 Color.Green);
            Random rnd = new();
            graphics.FillRectangle(linearGradientBrush, 200, 200,
                300, 300);
            //while (true) раскомментировать для эпилептиков
            {
                Thread.Sleep(10);
                graphics.Clear(Color.FromArgb(rnd.Next(0,255),
                    rnd.Next(0, 255), rnd.Next(0, 255)));
            }

            Console.ReadLine();
        }

    }
}