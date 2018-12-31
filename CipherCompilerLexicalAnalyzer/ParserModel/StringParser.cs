namespace DFAParser.ParserModel
{
    class StringParser : TokenParser
    {
        public StringParser()
        {
            //adding states to the dfa
            dfa.AddState(false, true); //1 initial state
            dfa.AddState(); //2
            dfa.AddState(); //3
            dfa.AddState(); //4
            dfa.AddState(true); //5 final state
            dfa.AddState(); //6
            dfa.AddState(true); //7 (5,6) final state
            //adding transitions to the dfa for acceptable words
            dfa.AddTransition(1, '"', 2);
            dfa.AddTransition(2, '"', 7);
            dfa.AddTransition(3, '"', 7);
            dfa.AddTransition(4, '"', 5);
            //adding transitions to the dfa for letters other than "
            foreach (var item in letterSet.OtherLetters(new char[] { '"' }))
            {
                dfa.AddTransition(1, item, 6);
                dfa.AddTransition(2, item, 3);
                dfa.AddTransition(3, item, 4);
                dfa.AddTransition(4, item, 3);
            }
            //adding transitions for all letters for unacceptable words
            foreach (var item in letterSet.Letters)
            {
                dfa.AddTransition(5, item, 6);
                dfa.AddTransition(6, item, 6);
            }
        }
    }
}
