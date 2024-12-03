using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNew
{
    public class CharacterLiteralEscapeSequence
    {
        public CharacterLiteralEscapeSequence()
        {
            char new_line = '\n';
            char backspace = '\b';
            char carriage_return = '\r';
            char horizontal_tab = '\t';


            //Character literal escape sequence
            char escape_char = '\e';

            Console.WriteLine((escape_char == (char)0x1b, "...").ToString());
            Console.WriteLine((escape_char == '\u001b', "..."));
            Console.WriteLine((escape_char == '\U0000001b', "..."));
            Console.WriteLine((escape_char == '\x1b', "..."));
        }



    }
}
