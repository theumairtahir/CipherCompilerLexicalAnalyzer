using System.Collections.Generic;

namespace DFAParser.ParserModel
{
    class BinaryOpParser : TokenParser
    {
        public BinaryOpParser()
        {
            //add states to the dfa
            dfa.AddState(false, true); //1, initial state
            dfa.AddState(true); //2, final state
            dfa.AddState(); //3
            //add transitions to the dfa, firstly for acceptable letters
            dfa.AddTransition(1, '^', 2);
            dfa.AddTransition(1, '-', 2);
            dfa.AddTransition(1, '+', 2);
            dfa.AddTransition(1, '/', 2);
            dfa.AddTransition(1, '*', 2);
            dfa.AddTransition(1, '%', 2);
            dfa.AddTransition(1, '=', 2);
            //add transition for others
            foreach (var item in letterSet.OtherLetters(new char[] { '^', '-', '+', '/', '*', '%', '=' }))
            {
                dfa.AddTransition(1, item, 3);
            }
            //add transitions for all
            foreach (var item in letterSet.Letters)
            {
                dfa.AddTransition(2, item, 3);
                dfa.AddTransition(3, item, 3);
            }
        }
    }
}
