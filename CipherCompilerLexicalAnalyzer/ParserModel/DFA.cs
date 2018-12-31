using System;
using System.Collections.Generic;

namespace DFAParser.ParserModel
{
    class DFA
    {
        LettersSet letterSet;
        List<State> lstStates = new List<State>();
        public DFA(LettersSet letterSet)
        {
            this.letterSet = letterSet;
        }
        public void AddState(bool isFinal = false, bool isStart = false)
        {
            //Method to add a new state
            State state = new State(letterSet, isFinal, isStart);
            if (lstStates.Count > 0)
            {
                foreach (var item in lstStates)
                {
                    if (item.IsStart && isStart)
                    {
                        throw new NoMoreStartStateException(); //A DFA has not more than one start state
                    }
                }
            }
            lstStates.Add(state);
        }
        public void AddTransition(int stateIndex, char letter, int nextState)
        {
            //Method to add transition between states according to the language
            stateIndex--;
            nextState--;
            if (stateIndex >= 0 && stateIndex < lstStates.Count)
            {
                lstStates[stateIndex].AddTransition(letter, lstStates[nextState]); //will throw an exception if next state will not be present
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public bool VerifyWord(string s)
        {
            //Method to verify the words of the language
            bool flag = false; //flag is the return value of this method, by default it is false
            State state = InitialState; //starting from the initial state
            foreach (var item in s.ToCharArray())
            {
                int i = lstStates.IndexOf(state);
                state = state[item]; //returns the next state according to the transition table
                if (state == null)
                    throw new MissingEdgeException(i+1, item);
            }
            if (state.IsFinal)
            {
                //if the last state is a final state then the method will return true
                flag = true;
            }
            return flag;
        }
        public State InitialState
        {
            get
            {
                foreach (var item in lstStates)
                {
                    if (item.IsStart)
                        return item;
                }
                throw new NoInitialStateFoundException();
            }
        }
        public LettersSet LetterSet
        {
            get
            {
                return letterSet;
            }
        }
    }
}
