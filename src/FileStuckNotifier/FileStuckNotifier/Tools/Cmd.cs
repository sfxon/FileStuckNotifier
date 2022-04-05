// <copyright file="Cmd.cs" company="Mindfav Software">
// Copyright (c) Mindfav Software. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>

namespace FileStuckNotifier.Tools
{
    using System;

    /// <summary>
    /// Tool for operations on the commandline.
    /// </summary>
    public static class Cmd
    {
        /// <summary>
        /// Formated default output in commandline.
        /// </summary>
        /// <param name="message">Message to print.</param>
        public static void Print(string message)
        {
            PrintColoredText(message, ConsoleColor.White);
        }

        /// <summary>
        /// Formated output of an error message in commandline.
        /// </summary>
        /// <param name="message">Message to print.</param>
        public static void PrintError(string message)
        {
            PrintColoredText(message, ConsoleColor.Red);
        }

        /// <summary>
        /// Formated output of message in a specific color in commandline.
        /// </summary>
        /// <param name="message">Message to print.</param>
        /// <param name="color"><see cref="ConsoleColor"/>.</param>
        public static void PrintColoredText(string message, ConsoleColor color)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = currentColor;
        }
    }
}
