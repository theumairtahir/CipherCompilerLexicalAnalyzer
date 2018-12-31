namespace DFAParser.ParserModel
{
    class ReserveWordParser : TokenParser
    {
        public ReserveWordParser()
        {
            //adding 5 states to the DFA
            dfa.AddState(false, true); //1 intial state
            dfa.AddState(); // 2
            dfa.AddState(); //3
            dfa.AddState(true); //4 final state
            dfa.AddState(); //5
            //adding transitions for acceptable letters
            dfa.AddTransition(1, 'v', 2);
            dfa.AddTransition(2, 'a', 3);
            dfa.AddTransition(3, 'r', 4);
            //transition for other from state 1
            foreach (var item in letterSet.OtherLetters(new char[] { 'v' }))
            {
                dfa.AddTransition(1, item, 5);
            }
            //transition for other from state 2
            foreach (var item in letterSet.OtherLetters(new char[] { 'a' }))
            {
                dfa.AddTransition(2, item, 5);
            }
            //transition for other from state 3
            foreach (var item in letterSet.OtherLetters(new char[] { 'r' }))
            {
                dfa.AddTransition(3, item, 5);
            }
            //transitions of all from states 4 and 5 respectively
            foreach (var item in letterSet.Letters)
            {
                dfa.AddTransition(4,item,5);
                dfa.AddTransition(5, item, 5);
            }
        }
        
    }
}
