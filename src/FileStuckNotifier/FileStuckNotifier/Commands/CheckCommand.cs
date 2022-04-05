// <copyright file="CheckCommand.cs" company="Mindfav Software">
// Copyright (c) Mindfav Software. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>

namespace FileStuckNotifier.Commands
{
    using DomainLayer.BusinessLogic.Commands;
    using DomainLayer.BusinessLogic.Exceptions;
    using FileStuckNotifier.Tools;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Command for checking a folder and sending a mail, if not empty.
    /// </summary>
    public class CheckCommand
    {
        /// <summary>
        /// Command to save a setting.
        /// </summary>
        /// <param name="serviceProvider"><see cref="IServiceProvider" />.</param>
        /// <param name="args">Array of type string, which contains the commandline parameters.</param>
        /// <returns>True, if successful, false otherwise.</returns>
        public static bool FolderIsNotEmpty(IServiceProvider serviceProvider, string[] args)
        {
            // Check, if the required command line parameters are given.
            if (
                args.Length != 2 ||
                string.IsNullOrEmpty(args[0]) ||
                string.IsNullOrEmpty(args[1]))
            {
                CheckCommand.PrintUsageError();
                return false;
            }

            // Call business logic to write the setting.
            var checkLogic = serviceProvider.GetRequiredService<CheckLogic>();

            try
            {
                checkLogic.CheckFolder(args[1]);
            }
            catch (DirectoryDoesNotExistException)
            {
                Cmd.PrintError("Das Verzeichnis '" + args[1] + "' wurde nicht gefunden.");
                throw;
            }

            return true;
        }

        /// <summary>
        /// Print error about wrong usage of the command.
        /// </summary>
        public static void PrintUsageError()
        {
            Cmd.PrintError(Messages.CheckCommandUsageError);
            PrintUsageInfo();
        }

        /// <summary>
        /// Print error about invalid options.
        /// </summary>
        public static void PrintUsageInfo()
        {
            Cmd.PrintError(Messages.CheckCommandUsageInfo);
        }
    }
}
