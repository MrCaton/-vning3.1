using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Util
    {
        internal static string AskForString(string prompt, IUI ui)
        {
            bool success = false;
            string answer; 

            do 
            {
                ui.Print(prompt);
                answer = ui.GetInput();

                
                if (!string.IsNullOrEmpty(answer))
                {
                    
                    success = true;
                }

            } while (!success);

            return answer; 
        }

        internal static int AskForInt(string prompt, IUI ui)
        {
            bool success = false;
            int answer; 

            do 
            {
              
                string input = AskForString(prompt, ui);

                success = int.TryParse(input, out answer);
                if (!success)
                    ui.Print("Wrong format"); 

            } while (!success);

            return answer;
        }
    }
}
