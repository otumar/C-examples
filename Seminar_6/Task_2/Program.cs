﻿// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = prompt("Введите сторону A треугольника ");
int b = prompt("Введите сторону B треугольника ");
int c = prompt("Введите сторону C треугольника ");

if ((a<b+c) && (b<a+c) && (c<a+b)) //\________/
{
    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
}
else 
{
    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не существует");
}