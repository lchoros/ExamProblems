using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();
            int messageCounter = 0;

            string encryptedMessage = string.Empty;
            while (command.ToLower() != "end")
            {
                command = Console.ReadLine();

                for (int i = 0; i < command.Length; i++)
                {
                    if ((command[i] >= 'A' && command[i] <= 'M') || (command[i] >= 'a' && command[i] <= 'm'))
                    {
                        encryptedMessage =  (char)(command[i] + 13) + encryptedMessage;                        
                    }
                    else if ((command[i] >= 'N' && command[i] <= 'Z') || (command[i] >= 'n' && command[i] <= 'z'))
                    {
                        encryptedMessage = (char)(command[i] - 13) + encryptedMessage;
                    }

                }

                messageCounter++;

            }

            if (messageCounter == 0)
            {
                Console.WriteLine("No messages sent.");
            }
        }
    }
}
