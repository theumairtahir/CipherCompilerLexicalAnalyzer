using System.Collections.Generic;

namespace DFAParser.ParserModel
{
    class TokenParser
    {
        protected LettersSet letterSet;
        protected DFA dfa;
        protected TokenParser()
        {
            letterSet = new LettersSet();
            letterSet.AddLetters(0, 127); //add all ascii characters to the letter set
            dfa = new DFA(letterSet); //add the letter set to the DFA
        }
        public TokenParser(DFA dfa)
        {
            letterSet = dfa.LetterSet;
            this.dfa = dfa;
        }
        public bool VerifyWord(string word)
        {
            //Method to verify a word according to the above DFA
            return dfa.VerifyWord(word);
        }
        public List<string> GenerateTokens(string s)
        {
            List<string> lstTokens = new List<string>();
            //removes the white space
            s = s.Replace(" ", string.Empty);
            char[] charATemp = s.ToCharArray(); //taking a temporary char array to store the converted string to char array
            //index is a variable which will store the position to read from the char array
            for (int index = 0; index < charATemp.Length; index++)
            {
                string sTemp = string.Empty; //taking a temporary string to make and verify words
                string lastValidWord = null;
                for (int i = index; i < charATemp.Length; i++) //this loop will iterate from a specified position to the end of the temp array
                {
                    sTemp += charATemp[i]; //adding each char to the string to make a whole word and then verify it
                    if (VerifyWord(sTemp))
                    {
                        //the word is verified then store it as the last valid and procceed to check further
                        //whether it could be some other valid word
                        //every single valid word in this proccess will overwrite the last valid word
                        lastValidWord = sTemp;
                        index = i; //set the new position to iterate at the end of the verified word
                    }
                }
                if (lastValidWord != null)
                {
                    lstTokens.Add(lastValidWord); //eventually the last valid word will be added to tokens list
                }
            }
            return lstTokens;
        }
    }
}
