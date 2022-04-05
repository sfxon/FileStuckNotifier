// <copyright file="ResultCode.cs" company="Mindfav Software">
// Copyright (c) Mindfav Software. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>

namespace FileStuckNotifier
{
    /// <summary>
    /// Result-Codes for commandline calls.
    /// </summary>
    public enum ResultCode
    {
        /// <summary>
        /// Application exited successfully.
        /// </summary>
        Ok = 0,

        /// <summary>
        /// An error occured during operation.
        /// </summary>
        Error = 1,

        /// <summary>
        /// Error in commandline arguments.
        /// </summary>
        WrongCommandLine = 2,
    }
}
