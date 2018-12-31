namespace DFAParser.ParserModel
{
    class UninaryOpParser : TokenParser
    {
        public UninaryOpParser()
        {
            //adding states to the dfa
            dfa.AddState(false, true); //1 initial state
            dfa.AddState(true); //2 final
            dfa.AddState(true); //3 final
            dfa.AddState(true); //4 final
            dfa.AddState(true); //5 final
            dfa.AddState(true); //6 final
            dfa.AddState(true); //7 final
            dfa.AddState(); //8
            //adding transitions to the dfa for acceptable letters
            dfa.AddTransition(1, '@', 2);
            dfa.AddTransition(1, '&', 3);
            dfa.AddTransition(1, '!', 4);
            dfa.AddTransition(2, '@', 5);
            dfa.AddTransition(3, '&', 6);
            dfa.AddTransition(4, '!', 7);
            //adding transitions to the dfa for other letters except @, &, !
            foreach (var item in letterSet.OtherLetters(new char[] { '@', '&', '!' }))
            {
                dfa.AddTransition(1, item, 8);
            }
            //adding transitions to the dfa for other letters except @
            foreach (var item in letterSet.OtherLetters(new char[] { '@' }))
            {
                dfa.AddTransition(2, item, 8);
            }
            //adding transitions to the dfa for other letters except &
            foreach (var item in letterSet.OtherLetters(new char[] { '&' }))
            {
                dfa.AddTransition(3, item, 8);
            }
            //adding transitions to the dfa for other letters except !
            foreach (var item in letterSet.OtherLetters(new char[] { '!' }))
            {
                dfa.AddTransition(4, item, 8);
            }
            //adding transitions to the dfa for all letters
            foreach (var item in letterSet.Letters)
            {
                dfa.AddTransition(5, item, 8);
                dfa.AddTransition(6, item, 8);
                dfa.AddTransition(7, item, 8);
                dfa.AddTransition(8, item, 8);
            }
        }
    }
}
