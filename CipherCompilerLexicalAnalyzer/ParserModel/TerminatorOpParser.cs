namespace DFAParser.ParserModel
{
    class TerminatorOpParser : TokenParser
    {
        public TerminatorOpParser()
        {
            //adding states to the dfa
            dfa.AddState(false, true); // 1 initial state
            dfa.AddState(true); //2 final state
            dfa.AddState(); //3
            //adding transitions for acceptable words
            dfa.AddTransition(1, ';', 2);
            //adding transitions for other letters except ;
            foreach (var item in letterSet.OtherLetters(new char[] { ';' }))
            {
                dfa.AddTransition(1, item, 3);
            }
            //adding transitions for all letters
            foreach (var item in letterSet.Letters)
            {
                dfa.AddTransition(2, item, 3);
                dfa.AddTransition(3, item, 3);
            }
        }
    }
}
