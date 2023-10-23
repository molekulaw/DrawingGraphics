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

            Pen pen = new Pen(Color.Pink, 2);
            graphics.DrawEllipse(pen, 400, 400, 400, 400);

            graphics.DrawLine(pen, 300, 350, 460, 450); // левое ухо
            graphics.DrawLine(pen, 300, 350, 400, 580);

            graphics.DrawLine(pen, 900, 350, 750, 450); // правое ухо
            graphics.DrawLine(pen, 900, 350, 805, 600);

            Pen peN = new Pen(Color.White, 2);
            graphics.DrawLine(peN, 200, 500, 460, 450);
            graphics.DrawLine(peN, 200, 350, 460, 450);
            graphics.DrawLine(peN, 200, 350, 460, 450);
            graphics.DrawLine(peN, 200, 350, 460, 450);


            SolidBrush solidBrush = new SolidBrush(
                Color.Black);
            graphics.FillEllipse(solidBrush, 700, 550, 60, 60); //100 - X и Y, 30 - длина
            graphics.FillEllipse(solidBrush, 500, 550, 60, 60); //100 - X и Y, 30 - длина

            SolidBrush soolidBrush = new SolidBrush(
                Color.White);
            graphics.FillEllipse(soolidBrush, 730, 560, 15, 15); //100 - X и Y, 30 - длина
            graphics.FillEllipse(soolidBrush, 530, 560, 15, 15); //100 - X и Y, 30 - длина

            Pen pEn = new Pen(Color.Pink, 2);
            graphics.DrawCurve(pEn, new Point[] {
                new Point(700, 800),
                new Point(600, 600),
                new Point(600, 400),
                new Point(600, 400)
            });

            Console.ReadLine();

        }

    }
}


//// методы, начинающиеся на Draw - рисуют контуры, для рисования используется ручка (Pen)
//// методы, начинающиеся на Fill - заливка, для рисования
//// используется кисть (SolidBrush, LinearGradientBrush, TextureBrush)
//// цвета используются через класс Color
//Pen pen = new Pen(Color.Red, 2); // красная ручка, толщиной 2px
////graphics.DrawEllipse(pen, 100, 100, 30, 30); 100 - X и Y, 30 - длина
////graphics.DrawLine(pen, 100, 100, 150, 150);     // и ширина

//GraphicsPath graphicsPath = new GraphicsPath();
//graphicsPath.AddEllipse(100, 100, 30, 30);
//Rectangle rectangle = new Rectangle
//{
//    X = 100,
//    Y = 100,
//    Height = 100,
//    Width = 100
//};
//graphicsPath.AddRectangle(rectangle);
//graphics.DrawPath(pen, graphicsPath);

//graphics.DrawBezier(pen, 100, 100, 150, 150, 200, 100, 250, 150);

//graphics.DrawCurve(pen, new Point[] {
//    new Point(100, 100),
//    new Point(150, 150),
//    new Point(200, 150),
//    new Point(250, 100),
//    new Point(255, 400)
//});
//pen.Color = Color.White;
//graphics.DrawLines(pen, new Point[] {
//    new Point(100, 100),
//    new Point(150, 150),
//    new Point(200, 150),
//    new Point(250, 100),
//    new Point(255, 400)
//});

//graphics.FillClosedCurve(Brushes.PaleVioletRed, new Point[] {
//    new Point(100, 100),
//    new Point(150, 150),
//    new Point(200, 150),
//    new Point(250, 100),
//    new Point(255, 400)
//});

//SolidBrush solidBrush = new SolidBrush(
//    Color.FromArgb(255, 10, 100));


//LinearGradientBrush linearGradientBrush =
//    new LinearGradientBrush(new PointF(0, 0),
//     new PointF(100, 100), Color.Blue,
//     Color.Green);
//Random rnd = new();
//graphics.FillRectangle(linearGradientBrush, 200, 200,
//    300, 300);
////while (true) раскомментировать для эпилептиков
//{
//    Thread.Sleep(10);
//    graphics.Clear(Color.FromArgb(rnd.Next(0,255),
//        rnd.Next(0, 255), rnd.Next(0, 255)));
//}

//Console.ReadLine();