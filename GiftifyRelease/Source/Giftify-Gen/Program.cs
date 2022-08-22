using System;
using System.Drawing;
using System.Threading;
using Console = Colorful.Console;

namespace Giftify_Gen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logo();
            Console.Write(" [-] ", Color.LemonChiffon);
            Console.Write("Note : Any code generated, are not verified\n codes may have already been used or invalid.", Color.GhostWhite);
            Console.WriteLine();
            Generator.Init();
        }

        public static void Logo()
        {
            Console.Clear();
            Console.Title = "Giftify Gen (Nitro Gen) - By SexyAzure";
            Console.WriteLineFormatted(@"                                             _____ _  __ _   _  __       ", Color.LimeGreen, Color.LimeGreen);
            Console.WriteLineFormatted(@"                                            / ____(_)/ _| | (_)/ _|      ", Color.LimeGreen, Color.LimeGreen);
            Console.WriteLineFormatted(@"                                           | |  __ _| |_| |_ _| |_ _   _ ", Color.LimeGreen, Color.LimeGreen);
            Console.WriteLineFormatted(@"                                           | | |_ | |  _| __| |  _| | | |", Color.LimeGreen, Color.LimeGreen);
            Console.WriteLineFormatted(@"                                           | |__| | | | | |_| | | | |_| |", Color.LimeGreen, Color.LimeGreen);
            Console.WriteLineFormatted(@"                                            \_____|_|_|  \__|_|_|  \__, |", Color.LimeGreen, Color.LimeGreen);
            Console.WriteLineFormatted(@"                                                                    __/ |", Color.GhostWhite, Color.LimeGreen);
            Console.WriteLineFormatted(@"                                                {0}     |___/ ", Color.GhostWhite, Color.LimeGreen, (object)"By : SexyAzure");
            Console.WriteLine();
        }
    }
}
