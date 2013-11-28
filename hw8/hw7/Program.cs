﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw7.Classes;

namespace hw7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> pointsList = new List<Point>();
            pointsList.Add(new Point(1, 1));
            pointsList.Add(new Point(1, 2));
            pointsList.Add(new Point(2, 2));
            pointsList.Add(new Point(2, 1));

            Square square = new Square(pointsList);
            Console.WriteLine(square.Perimeter);
            Console.WriteLine(square.Area);
        }
    }
}

/*
Задание  2.  Разработать  абстрактный  класс  ГеометрическаяФигура  со  свойствами

ПлощадьФигуры   и   ПериметрФигуры.   
Разработать   классы-наследники:   Треугольник, Квадрат, Ромб, Прямоугольник, Параллелограмм, Трапеция, Круг, Эллипс и реализовать конструкторы, которые однозначно определяют объекты данных классов.
Реализовать интерфейс ПростойНУгольник, который имеет свойства: Высота, Основание,   УголМеждуОснованиемИСмежнойСтороной,  КоличествоСторон,  ДлиныСторон, Площадь, Периметр.
Реализовать класс СоставнаяФигура который может состоять из любого количества

ПростыхНУгольников. Для данного класса определить метод нахождения площади фигуры.

Предусмотреть классы исключения невозможности задания фигуры (введены отрицательные длины сторон; 
или при создании объекта треугольника существует пара сторон, сума длин которых меньше длины третей стороны; и т.п.)

Создать диаграммы взаимоотношений классов и интерфейсов.
*/

 //diamond, rectangle, parallelogram, trapezoid, circle, ellipse