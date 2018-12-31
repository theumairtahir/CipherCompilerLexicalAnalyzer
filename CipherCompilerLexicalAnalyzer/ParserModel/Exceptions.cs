using System;
using System.Collections.Generic;

namespace DFAParser.ParserModel
{
    public class LetterAlreadyAddedException : Exception
    {
        public LetterAlreadyAddedException(char letter) : base(letter + " is already present in the list. The DFA couldn't contain duplicate letters.")
        {

        }

    }
    public class LettersAlreadyAddedException : Exception
    {
        string message = "";
        public LettersAlreadyAddedException(List<char> letters)
        {
            foreach (var item in letters)
            {
                message = message + item + " ";
            }
            message += "is/are already present in the list. The DFA couldn't contain duplicate letters.";
        }
        public override string Message
        {
            get
            {
                return message;
            }
        }
    }
    public class NoSuchLetterFoundException : Exception
    {
        public NoSuchLetterFoundException(char letter) : base("No such letter found. " + letter + " is not present in the set of defined letters.")
        {

        }
    }
    public class NoMoreStartStateException : Exception
    {
        public NoMoreStartStateException() : base("A DFA cannot have more than one start state.")
        {

        }
    }
    public class NoInitialStateFoundException : Exception
    {
        public NoInitialStateFoundException() : base("A DFA must have an Initial State.")
        {

        }
    }
    public class MissingEdgeException : Exception
    {
        public MissingEdgeException(int stateIndex, char letter) : base("There is a missing edge on " + stateIndex + " state for " + letter + ". A DFA cannot have a missing edge.")
        {

        }
    }
}
