// <copyright file="FileSystemIsNullException.cs" company="Mindfav Software">
// Copyright (c) Mindfav Software. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>

namespace DomainLayer.BusinessLogic.Exceptions
{
    /// <summary>
    /// Exception for the case, that a directory does not exist.
    /// </summary>
    public class DirectoryDoesNotExistException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryDoesNotExistException"/> class.
        /// </summary>
        /// <param name="message">The message to throw.</param>
        public DirectoryDoesNotExistException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryDoesNotExistException"/> class.
        /// </summary>
        /// <param name="message">The message to throw.</param>
        /// <param name="innerException">Encapsuled exception of type <see cref="Exception"/>.</param>
        public DirectoryDoesNotExistException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryDoesNotExistException"/> class.
        /// </summary>
        public DirectoryDoesNotExistException()
            : base()
        {
        }
    }
}
