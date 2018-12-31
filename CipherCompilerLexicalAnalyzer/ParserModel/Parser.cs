namespace DFAParser.ParserModel
{
    class Parser
    {
        protected LettersSet letterSet;
        protected DFA dfa;
        protected Parser()
        {
            letterSet = new LettersSet();
            letterSet.AddLetters(0, 127); //add all ascii characters to the letter set
            dfa = new DFA(letterSet); //add the letter set to the DFA
        }
    }
}
