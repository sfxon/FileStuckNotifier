using DomainLayer.BusinessLogic.Configuration;
using DomainLayer.BusinessLogic.Exceptions;
using Microsoft.Extensions.Options;
using System.IO.Abstractions;
using System.Net.Mail;

namespace DomainLayer.BusinessLogic.Commands
{
    /// <summary>
    /// Implementation of the command line command to write a setting.
    /// </summary>
    public class CheckLogic
    {
        private readonly ApplicationConfiguration applicationConfiguration;
        private readonly IFileSystem? fileSystem = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckLogic"/> class.
        /// </summary>
        /// <param name="appConfig">Current application configuration.</param>
        /// <param name="fileSystem"><see cref="IFileSystem"/>.</param>
        /// <returns>True if successful, otherwise false.</returns>
        public CheckLogic(
            IOptions<ApplicationConfiguration> appConfig,
            IFileSystem fileSystem)
        {
            this.applicationConfiguration = appConfig.Value;
            this.fileSystem = fileSystem;
        }

        /// <summary>
        /// Checks if a directory is empty.
        /// If not, it sends a mail.
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public bool CheckFolder(string directory)
        {
            var dir = this.fileSystem!.DirectoryInfo.FromDirectoryName(directory);

            if(!dir.Exists)
            {
                throw new DirectoryDoesNotExistException();
            }

            if(dir.EnumerateFiles().Any() || dir.EnumerateDirectories().Any())
            {
                // Send mail..
                this.SendMail(directory);

                return false;
            }

            return true;
        }

        private void SendMail(string directory)
        {
            string from = applicationConfiguration.MailUsername!;
            string to = from;
            string projectName = applicationConfiguration.ProjectName!;

            MailMessage msg = new(from, to)
            {
                Subject = "Project: " + projectName + " - Directory was not empty.",
                Body = "The directory " + directory + " was not empty. Please check the project."
            };

            SmtpClient smtp = new(
                applicationConfiguration.MailHostname!,
                Int32.Parse(applicationConfiguration.MailPort!))
            {
                Credentials = new System.Net.NetworkCredential(
                    applicationConfiguration.MailUsername!,
                    applicationConfiguration.MailPassword!),
                EnableSsl = true
            };

            smtp.Send(msg);
        }
    }
}
