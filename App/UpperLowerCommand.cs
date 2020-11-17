using McMaster.Extensions.CommandLineUtils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace App
{
    [Command(Name = "UpperLowerCli", FullName = "UpperLower CLI", Description = "An UpperLower CLI Tool.")]
    [VersionOptionFromMember(MemberName = nameof(GetVersion))]
    [HelpOption]
    public class UpperLowerCommand
    {
        [Required]
        [Argument(0, "Text", "Some text to upperize or lowerize")]
        public string Text { get; set; }

        [Option("-u|--upper", "Convert the text to uper case.", CommandOptionType.NoValue)]
        public bool UpperCase { get; set; }

        [Option("-l|--lower", "Convert the text to lower case.", CommandOptionType.NoValue)]
        public bool LowerCase { get; set; }

        public void OnExecute(CommandLineApplication app)
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                app.ShowHelp();
                return;
            }

            if (UpperCase)
            {
                ConsoleColor.Magenta.WriteLine(Text.ToUpper());
                return;
            }
                
            if (LowerCase)
            {
                ConsoleColor.Yellow.WriteLine(Text.ToLower());
                return;
            }

            ConsoleColor.Cyan.WriteLine(Text);
        }

        private static string GetVersion()
        {
            return typeof(UpperLowerCommand)
                .Assembly
                ?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                .InformationalVersion;
        }
    }
}
