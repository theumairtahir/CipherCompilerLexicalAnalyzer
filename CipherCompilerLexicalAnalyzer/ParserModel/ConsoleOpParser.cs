namespace DFAParser.ParserModel
{
    class ConsoleOpParser : TokenParser
    {
        public ConsoleOpParser()
        {
            //adding states to the dfa
            dfa.AddState(false, true); //1 initial state
            dfa.AddState(); //2
            dfa.AddState(); //3
            dfa.AddState(); //4
            dfa.AddState(); //5
            dfa.AddState(true); //6 final state
            dfa.AddState(true); //7 final state
            dfa.AddState(); //8
            //adding transitions to the dfa for acceptable words
            dfa.AddTransition(1, 'c', 2);
            dfa.AddTransition(1, '<', 3);
            dfa.AddTransition(2, '-', 4);
            dfa.AddTransition(3, '-', 5);
            dfa.AddTransition(4, '>', 6);
            dfa.AddTransition(5, 'c', 7);
            //adding transitions to the dfa for other letters except c, <
            foreach (var item in letterSet.OtherLetters(new char[] { 'c', '<' }))
            {
                dfa.AddTransition(1, item, 8);
            }
            //adding transitions to the dfa for other letters except -
            foreach (var item in letterSet.OtherLetters(new char[] { '-' }))
            {
                dfa.AddTransition(2, item, 8);
                dfa.AddTransition(3, item, 8);
            }
            //adding transitions to the dfa for other letters except >
            foreach (var item in letterSet.OtherLetters(new char[] { '>' }))
            {
                dfa.AddTransition(4, item, 8);
            }
            //adding transitions to the dfa for other letters except c
            foreach (var item in letterSet.OtherLetters(new char[] { 'c' }))
            {
                dfa.AddTransition(5, item, 8);
            }
            //adding transitions to all
            foreach (var item in letterSet.Letters)
            {
                dfa.AddTransition(6, item, 8);
                dfa.AddTransition(7, item, 8);
                dfa.AddTransition(8, item, 8);
            }

        }
    }
}
