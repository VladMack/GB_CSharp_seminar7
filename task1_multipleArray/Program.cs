using MyClasses;
using System;

Console.Clear();

int n = int.Parse(Console.ReadLine);
int m = int.Parse(Console.ReadLine);

int[,] array = MyExample.GetArray(n, m, 0, 100);

MyExample.PrintArray(array);