// <copyright file="ApplicationConfiguration.cs" company="Mindfav Software">
// Copyright (c) Mindfav Software. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>

namespace DomainLayer.BusinessLogic.Configuration
{
    /// <summary>
    /// Class for the application configuration.
    /// </summary>
    /// <remarks>
    /// Provided by the dependency injection.
    /// </remarks>
    public sealed class ApplicationConfiguration
    {
        /// <summary>
        /// Gets or sets the Mail-Server Hostname;
        /// </summary>
        public string? MailHostname { get; set; }

        /// <summary>
        /// Gets or sets the Mail-Server Port
        /// </summary>
        public string? MailPort { get; set; }

        /// <summary>
        /// Gets or sets the Mail-Accounts username
        /// </summary>
        public string? MailUsername { get; set; }

        /// <summary>
        /// Gets or sets the Mail-Accounts password
        /// </summary>
        public string? MailPassword { get; set; }

        /// <summary>
        /// Name des Projektes, damit sich leichter zuordnen lässt, welches Projekt den Fehler meldet.
        /// </summary>
        public string? ProjectName { get; set; }
    }
}
