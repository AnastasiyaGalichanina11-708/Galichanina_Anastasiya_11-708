using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сond1
{
    class Program
    { enum TypeOfFigure
        {
            Elephant,
            Horse,
            Rook,
            Queen,
            King,
        }


       public static bool CheckMoveCorrechess(int coordX1, int coordY1, int coordX2, int coordY2)// Не знаю как завести метод, что в нем можно было ипользовать 
       {                                                                                         // переменную типа Bool
        var dx = Math.Abs(coordX2 - coordX1); //смещение фигуры по горизонтали
        var dy = Math.Abs(coordY2 - coordY1);//смещение фигуры по вертикали
       if (TypeOfFigure == 0)
           return (dx == dy && !(dx == 0 && dy == 0));     //  Elephant
        if (TypeOfFigure == 1)
           return (((dx == 2 && dy == 1) || (dx == 1 && dy == 2)) && !(dx == 0 && dy == 0));// Horse
        if (TypeOfFigure == 2)
           return (((dy == 0 && dx != 0) || (dx == 0 && dy != 0)) && !(dx == 0 && dy == 0));// Rook
        if (TypeOfFigure == 3)
           return ((dx == dy || (dy == 0 && dx != 0) || (dx == 0 && dy != 0)) && !(dx == 0 && dy == 0));//Queen
        if (TypeOfFigure == 4)
           return (((dx == 1 && dy == 0) || (dx == 0 && dy == 1) || (dx == dy == 1)) && !(dx == 0 && dy == 0));// King

        }


        
    }
}
