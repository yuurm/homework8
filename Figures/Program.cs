﻿using System;
using System.Collections.Generic;
using System.Text;
using Library.figures;
using Library.figures.@abstract;

namespace Figures
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            // 
            // foreach (var figure in figures)
            // {
            //     Console.WriteLine($"{figure.ToString()} - {figure.GetColor()}");
            // }
            
           //  //var d = new D();
           //  var a = new A();
           //  var b = new B();
           //
           // // var a = new A();
           //  
           //  bool result = b is A;
           //  
           //  Console.WriteLine(result);

            // Circle:5
            // Square:10
            // Triangle:10,4,4

            // List<Figure> figures = new List<Figure>();
            // int number = 0;
            // while (true)
            // {
            //     string str = Console.ReadLine();
            //
            //     if (str == "EXIT")
            //     {
            //         break;
            //     }
            //     
            //     string[] arguments = str.Split(":");
            //     string title = arguments[0];
            //
            //     if (Enum.TryParse(typeof(FigureType), title, true, out var temp))
            //     {
            //         FigureType figureType = (FigureType)temp;
            //         Figure figure = null;
            //         
            //         string[] strValues = arguments[1].Split(",");
            //         double[] values = new double[strValues.Length];
            //         for (int i = 0; i < strValues.Length; i++)
            //         {
            //             values[i] = Convert.ToDouble(strValues[i]);
            //         }
            //         
            //         switch (figureType)
            //         {
            //             case FigureType.Circle:
            //                 figure = new Circle(values[0], number);
            //                 break;
            //             
            //             case FigureType.Square:
            //                 figure = new Square(values[0], number);
            //                 break;
            //             
            //             case FigureType.Triangle:
            //                 figure = new Triangle(values[0],values[1],values[2], number);
            //                 break;
            //             default:
            //                 throw new Exception("Не знаю такую фигуру");
            //         }
            //
            //         number++;
            //         figures.Add(figure);
            //     }
            //     else
            //     {
            //         Console.WriteLine("Не знаю такую фигуру");
            //     }
            // }
            //


            var logger = new FileLogger("log.txt");
            
            IFigure[] figures = new IFigure[] { 
                new Circle(4, 1), 
                new Square(55, 2), 
                new Cube(77, 88),
                new Circle(3, 4), 
                new Square(33, 5), 
                new Triangle(1,5,6,9),
                new Cube(88, 9999)
            };
            
            double summ = 0;
            
            foreach (var figure in figures)
            {
                // if (figure is ThreeDimensionFigure threeDimensionFigure)
                // {
                //     summ += threeDimensionFigure.Volume;
                // } 
                logger.Log($"{figure}:{figure.Perimeter}");
                
                summ += figure.Perimeter;
            }
            
            logger.Dispose();
            
            Console.WriteLine($"Суммарная площадь всех фигур: {summ}");
            
            //
            // Console.WriteLine("Areas.");
            // Console.WriteLine(CalculateAreas(figures));
            //
            // Console.WriteLine("Perimeters.");
            // Console.WriteLine(CalculatePerimeters(figures));
            
        }
        
        // public class A
        // {
        //     protected string S { get; set; }
        //     public int I { get; set; }
        // }
        //
        // public class B : A
        // {
        //     public int K { get; set; }
        //
        //     public void Temp()
        //     {
        //         S = "sdfsdf";
        //     }
        // }
        //
        // public class C : B
        // {
        //     public int G { get; set; }
        //
        // }
        //
        //
        // public class D : C
        // {
        //     public int LL { get; set; }
        //
        // }

        static string CalculateAreas(List<IFigure> figures)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var figure in figures)
            {
                var str = $"{figure.GetTitle()}:{figure.Area:F1}";
                sb.AppendLine(str);
            }

            return sb.ToString();
        }
        
        static string CalculatePerimeters(List<IFigure> figures)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var figure in figures)
            {
                var str = $"{figure.GetTitle()}:{figure.Perimeter:F1}";
                sb.AppendLine(str);
            }

            return sb.ToString();
        }
    }
}