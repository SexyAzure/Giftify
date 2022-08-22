using System;
using System.Collections.Generic;
using System.Text;
using Console = Colorful.Console;
using System.Drawing;
using System.IO;
using System.Threading;

namespace Giftify_Gen
{
    internal class Generator
    {
        static int amount;

        static List<string> codeSave = new List<string> { };

        static string generatorDate;

        public static void Init()
        {
            Console.WriteLine();

            Console.Write(" [-] ", Color.LemonChiffon);
            Console.Write("How many codes do you want to generate?", Color.GhostWhite);
            Console.WriteLine();
            Console.Write(" >> ", Color.LemonChiffon);
            try
            {
                string tmp = Console.ReadLine();
                amount = Int32.Parse(tmp);
                if (amount <= 0)
                {
                    throw new Exception("Please enter a valid number!");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();

                Console.Write($" [!] ", Color.Red);
                Console.Write($"{ex.Message}", Color.GhostWhite);

                Console.WriteLine();
                Console.Write(" [!] ", Color.Orange);
                Console.Write("Please Retry!", Color.GhostWhite);

                Thread.Sleep(1500);

                Init();
            }

            Start();
        }

        public static void Start()
        {
            char[] alpha = "AfnOmhIFoWUb73dauQpLg6XwqJxiNY5T1r4SlkvztH2yeBsGE8DRPCVMcKZ9".ToCharArray();

            generatorDate = DateTime.Now.ToString();

            Program.Logo();
            Console.Write(" [-] ", Color.LemonChiffon);
            Console.Write("Note : Any code generated, are not verified\n codes may have already been used or invalid.", Color.GhostWhite);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" [!] ", Color.LimeGreen);
            Console.Write($"Starting Generator at : {generatorDate}!", Color.GhostWhite);
            
            Thread.Sleep(2000);

            for (int i = 0; i < amount; i++)
            {
                List<char> tmpCode = new List<char> { };
                for (int j = 0; j < 16; j++)
                {
                    Random rand = new Random();
                    int itemNum = rand.Next(0, alpha.Length - 1);
                    char tmpChar = alpha[itemNum];
                    tmpCode.Add(tmpChar);
                }
                string completeCode = String.Join("", tmpCode);
                Console.WriteLineFormatted("{0} Code : {1}", Color.LimeGreen, Color.GhostWhite, (object)" [-] ", (object)completeCode);
                codeSave.Add(completeCode);
            }
            Save();
        }

        public static void Save()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory().ToString(), "Nitro.txt");
            string codeToString = String.Join("\n", codeSave);

            Console.WriteLine();
            Console.Write(" [!] ", Color.LimeGreen);
            Console.Write("Saved Generated Codes!", Color.GhostWhite);

            Thread.Sleep(2000);

            if (File.Exists(filePath))
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    codeSave.ForEach(s => sw.WriteLine("https://discord.gift/" + s));
                }
            }
            else
            {
                Console.WriteLine();
                Console.Write(" [-] ", Color.Red);
                Console.Write("Nitro.txt Does not Exist!", Color.GhostWhite);
                Console.WriteLine();

                Thread.Sleep(500);

                Console.Write(" [-] ", Color.LimeGreen);
                Console.Write("Nitro.txt Created!", Color.GhostWhite);
                Console.WriteLine();

                using (System.IO.FileStream fs = System.IO.File.Create(filePath))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    codeSave.ForEach(s => sw.WriteLine("https://discord.gift/" + s));
                }
            }

            Program.Logo();
            Console.Write(" [-] ", Color.LemonChiffon);
            Console.Write("Select an option", Color.GhostWhite);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write(" [1] ", Color.LemonChiffon);
            Console.Write("Exit", Color.GhostWhite);
            
            Console.WriteLine();

            Console.Write(" [2] ", Color.LemonChiffon);
            Console.Write("Main Menu", Color.GhostWhite);

            Console.WriteLine();
            Console.Write(" >> ", Color.LemonChiffon);

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    Environment.Exit(0);
                    break;
                case 'x':
                    Init();
                    break;
            }
        }
    }
}
