namespace DFAParser.ParserModel
{
    class State
    {
        bool isStart, isFinal;
        State[] transitionStates;
        LettersSet letterSet;
        public State(LettersSet letterSet, bool isFinal = false, bool isStart = false)
        {
            this.isStart = isStart;
            this.isFinal = isFinal;
            this.letterSet = letterSet;
            transitionStates = new State[letterSet.Letters.Length];
        }
        public void AddTransition(char letter, State nextState)
        {
            //Method to add transitions to a state
            transitionStates[letterSet[letter]] = nextState; //the logic is to get the index of the letter and on the same index store the next state
        }
        public void RemoveTransitionAt(char letter)
        {
            //Method to remove a transition at a certain letter
            transitionStates[letterSet[letter]] = null;
        }
        public bool IsStart
        {
            get
            {
                return isStart;
            }
        }
        public bool IsFinal
        {
            get
            {
                return isFinal;
            }
        }
        public State this[char letter]
        {
            //this indexer will return the next state on the given letter
            get
            {
                return transitionStates[letterSet[letter]];
            }
        }
    }
}
