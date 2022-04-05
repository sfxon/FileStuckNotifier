// <copyright file="Command.cs" company="Mindfav Software">
// Copyright (c) Mindfav Software. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>

namespace FileStuckNotifier
{
    using System;

    /// <summary>
    /// Class for commandline applications.
    /// </summary>
    internal class Command
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        /// <param name="name">Name of expected command.</param>
        /// <param name="handler">Command Handler.</param>
        public Command(string name, CommandHandler handler)
        {
            this.Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
            this.Handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        /// <summary>
        /// Handler Delegate.
        /// </summary>
        /// <param name="serviceProvider">Provider for logic classes.</param>
        /// <param name="args">Arguments from commandline application.</param>
        /// <returns><see cref="ResultCode"/>.</returns>
        public delegate ResultCode CommandHandler(IServiceProvider serviceProvider, string[] args);

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the handler.
        /// </summary>
        public CommandHandler Handler { get; }
    }
}
