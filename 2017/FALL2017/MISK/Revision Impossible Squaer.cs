
using System;

using System.Diagnostics;

using System.Drawing;



namespace RefactorMe

{

    // ## Прочитайте! ##

    //

    // Ваша задача привести код в этом файле в порядок. 

    // Для начала запустите эту программу.

    // Переименуйте всё, что называется неправильно. Это можно делать комбинацией клавиш Ctrl+R, Ctrl+R (дважды нажать Ctrl+R).

    // Повторяющиеся части кода вынесите во вспомогательные методы. Это можно сделать выделив несколько строк кода и нажав Ctrl+R, Ctrl+M

    // Избавьтесь от всех зашитых в коде числовых констант — положите их в переменные с понятными именами.

    // 

    // После наведения порядка проверьте, что ваш код стал лучше. 

    // На сколько проще после ваших переделок стало изменить размер фигуры? Повернуть её на некоторый угол? 

    // Научиться рисовать невозможный треугольник, вместо квадрата?



    class Drowing

    {

        static Bitmap Image = new Bitmap(800, 600);

        static float X, Y;

        static Graphics Graphics;



        public static void Initialize()

        {

            Image = new Bitmap(800, 600);

            Graphics = Graphics.FromImage(Image);

        }



        public static void SetPossition(float x0, float y0)

        {

            X = x0;

            Y = y0;

        }



        public static void Go(double length, double angle)

        {

            //Делает шаг длиной L в направлении angle и рисует пройденную траекторию

            var x1 = (float)(X + length * Math.Cos(angle));

            var y1 = (float)(Y + length * Math.Sin(angle));

            Graphics.DrawLine(Pens.Yellow, X, Y, x1, y1);

            X = x1;

            Y = y1;

        }



        public static void ShowResult()

        {

            Image.Save("result.bmp");

            Process.Start("result.bmp");

        }

    }



    public class StrangeThing

    {
        public static void DrowingSquare(float x1, float y1, double angleTurn1, double angleTurn2, double angleTurn3, double angleTurn4)
        {
            Drowing.SetPossition(x1, y1);

            Drowing.Go(100, angleTurn1);

            Drowing.Go(10 * Math.Sqrt(2),angleTurn2);

            Drowing.Go(100, angleTurn3);

            Drowing.Go(100 - (double)10, angleTurn4);

        }
        public static void Main()

        {

            Drowing.Initialize();
           

            DrowingSquare(10, 0, 0, Math.PI / 4, Math.PI, Math.PI / 2);
            DrowingSquare(120, 10, Math.PI / 2, Math.PI / 2 + Math.PI / 4, Math.PI / 2 + Math.PI, Math.PI / 2 + Math.PI / 2);
            DrowingSquare(110, 120, Math.PI, Math.PI + Math.PI / 4, Math.PI + Math.PI, Math.PI + Math.PI / 2);
            DrowingSquare(0, 110, -Math.PI / 2, -Math.PI / 2 + Math.PI / 4, -Math.PI / 2 + Math.PI, -Math.PI / 2 + Math.PI / 2);
           
            Drowing.ShowResult();

        }

    }

}