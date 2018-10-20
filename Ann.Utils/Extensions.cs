﻿using Gdo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ann.Utils
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
        {
            var i = 0;
            foreach (var e in source) action(e, i++);
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source)
                action(element);
        }

        public static void ForEach<T>(this T[,] source, Action<T> action)
        {
            for (int w = 0; w < source.GetLength(0); w++)
            {
                for (int h = 0; h < source.GetLength(1); h++)
                {
                    action(source[w, h]);
                }
            }
        }

        public static void ForEach<T>(this T[,] source, Action<T, int, int> action)
        {
            for (int w = 0; w < source.GetLength(0); w++)
            {
                for (int h = 0; h < source.GetLength(1); h++)
                {
                    action(source[w, h], w, h);
                }
            }
        }

        public static void ForEach<T>(this T[,] source, Action<int, int> action)
        {
            for (int w = 0; w < source.GetLength(0); w++)
            {
                for (int h = 0; h < source.GetLength(1); h++)
                {
                    action(w, h);
                }
            }
        }

        public static void ForEach<T>(this T[,,] source, Action<T, int, int, int> action)
        {
            for (int w = 0; w < source.GetLength(0); w++)
            {
                for (int h = 0; h < source.GetLength(1); h++)
                {
                    for (int d = 0; d < source.GetLength(2); d++)
                    {
                        action(source[w, h, d], w, h, d);
                    }
                }
            }
        }

        public static void ForEach<T>(this T[,,] source, Action<int, int, int> action)
        {
            for (int w = 0; w < source.GetLength(0); w++)
            {
                for (int h = 0; h < source.GetLength(1); h++)
                {
                    for (int d = 0; d < source.GetLength(2); d++)
                    {
                        action(w, h, d);
                    }
                }
            }
        }

        public static void ForEach<T>(this T[,,] source, Action<T> action)
        {
            for (int w = 0; w < source.GetLength(0); w++)
            {
                for (int h = 0; h < source.GetLength(1); h++)
                {
                    for (int d = 0; d < source.GetLength(2); d++)
                    {
                        action(source[w, h, d]);
                    }
                }
            }
        }

        public static void ForEach<T>(this T[,,,] source, Action<int, int, int, int> action)
        {
            for (int k = 0; k < source.GetLength(0); k++)
            {
                for (int d = 0; d < source.GetLength(1); d++)
                {
                    for (int h = 0; h < source.GetLength(2); h++)
                    {
                        for (int w = 0; w < source.GetLength(3); w++)
                        {
                            action(k,d,h,w);
                        }
                    }
                }
            }
        }

        public static void ForEach<T>(this T[,,,] source, Action<T,int, int, int, int> action)
        {
            for (int k = 0; k < source.GetLength(0); k++)
            {
                for (int d = 0; d < source.GetLength(1); d++)
                {
                    for (int h = 0; h < source.GetLength(2); h++)
                    {
                        for (int w = 0; w < source.GetLength(3); w++)
                        {
                            action(source[k, d, h, w], k, d, h, w);
                        }
                    }
                }
            }
        }
    }
}