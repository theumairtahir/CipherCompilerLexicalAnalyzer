using System;
using System.Collections.Generic;

namespace DFAParser.ParserModel
{
    class IdentifierParser : TokenParser
    {
        public IdentifierParser()
        {
            //add States to the DFA according to the RE
            dfa.AddState(false, true); //1 initial state
            dfa.AddState(); //2
            dfa.AddState(); //3
            dfa.AddState(true); //4 final state
            dfa.AddState(); //5
            //add transitions  to the DFA, firstly add the acceptable characters
            dfa.AddTransition(1, '[', 2);
            for (int i = '0'; i <= '9'; i++)
            {
                // transitions for 0-9 chars
                dfa.AddTransition(3, Convert.ToChar(i), 3);
            }
            for (int i = 'A'; i <= 'Z'; i++)
            {
                // transitions for A-Z chars
                dfa.AddTransition(2, Convert.ToChar(i), 3);
                dfa.AddTransition(3, Convert.ToChar(i), 3);
            }
            for (int i = 'a'; i <= 'z'; i++)
            {
                // transitions for a-z chars
                dfa.AddTransition(2, Convert.ToChar(i), 3);
                dfa.AddTransition(3, Convert.ToChar(i), 3);
            }
            dfa.AddTransition(3, ']', 4);
            //transitions for others
            foreach (var item in letterSet.OtherLetters(new char[] { '[' }))
            {
                //transition for others from state 1
                dfa.AddTransition(1, item, 5);
            }
            List<char> temp = new List<char>();
            //transition for others from state 2
            for (int i = 'A'; i <= 'Z'; i++)
            {
                temp.Add((char)i);
            }
            for (int i = 'a'; i <= 'z'; i++)
            {
                temp.Add((char)i);
            }
            foreach (var item in letterSet.OtherLetters(temp.ToArray()))
            {
                dfa.AddTransition(2, item, 5);
            }
            //other for state 3
            for (int i = '0'; i <= '9'; i++)
            {
                temp.Add((char)i);
            }
            temp.Add(']');
            foreach (var item in letterSet.OtherLetters(temp.ToArray()))
            {
                dfa.AddTransition(3, item, 5);
            }
            //transitions for all
            foreach (var item in letterSet.Letters)
            {
                dfa.AddTransition(4, item, 5);
                dfa.AddTransition(5, item, 5);
            }
        }
    }
}
