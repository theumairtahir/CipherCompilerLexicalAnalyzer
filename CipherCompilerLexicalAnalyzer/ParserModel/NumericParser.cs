using System.Collections.Generic;

namespace DFAParser.ParserModel
{
    class NumericParser : TokenParser
    {
        public NumericParser()
        {
            //add DFA states according to the DFA made from the RE
            dfa.AddState(false, true); //intial state
            for (int i = 0; i < 4; i++)
            {
                //mid 4 states which don't have either initial or final states
                dfa.AddState();
            }
            dfa.AddState(true); //state no. 6 which is final
            dfa.AddState(); //last state represented as null/phi state in the DFA
            //add transitions to the DFA, firstly add the acceptable characters
            dfa.AddTransition(1, '{', 2);
            dfa.AddTransition(2, '-', 3);
            dfa.AddTransition(2, '+', 3);
            dfa.AddTransition(2, '.', 5);
            dfa.AddTransition(3, '.', 5);
            dfa.AddTransition(4, '.', 5);
            dfa.AddTransition(4, '}', 6);
            dfa.AddTransition(5, '}', 6);
            //loop for 0-9 chars
            for (int i = 0; i < 10; i++)
            {
                dfa.AddTransition(5, i.ToString().ToCharArray()[0], 5);
                dfa.AddTransition(2, i.ToString().ToCharArray()[0], 4);
                dfa.AddTransition(3, i.ToString().ToCharArray()[0], 4);
                dfa.AddTransition(4, i.ToString().ToCharArray()[0], 4);
            }
            //transitions for other
            foreach (var item in letterSet.OtherLetters(new char[] { '{' }))
            {
                dfa.AddTransition(1, item, 7);
            }
            foreach (var item in letterSet.OtherLetters(new char[] { '-', '+', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }))
            {
                dfa.AddTransition(2, item, 7);
            }
            foreach (var item in letterSet.OtherLetters(new char[] { '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }))
            {
                dfa.AddTransition(3, item, 7);
            }
            foreach (var item in letterSet.OtherLetters(new char[] { '}', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }))
            {
                dfa.AddTransition(4, item, 7);
            }
            foreach (var item in letterSet.OtherLetters(new char[] { '}', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }))
            {
                dfa.AddTransition(5, item, 7);
            }
            foreach (var item in letterSet.Letters)
            {
                dfa.AddTransition(6, item, 7);
                dfa.AddTransition(7, item, 7);
            }
        }
    }
}
