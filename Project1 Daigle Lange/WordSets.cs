using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordSets
{
    public class WordSets
    {
        //Alphabet
        private char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        //List containging all words
        private List<String> Dict = new List<String>();

        //Dictonary containing indexes sorted into letters
        //ex:
        //    3 Letters
        //        1st letter
        //            a : hash of [indexes]
        //            b : hash of [indexes]

        //Word Length |Letter in word |all words that have a...z in them
        private Dictionary<int, Dictionary<int, Dictionary<char, HashSet<int>>>> set =
            new Dictionary<int, Dictionary<int, Dictionary<char, HashSet<int>>>>();

        //Current word length
        private int length = 0;

        //Current word list
        private List<int> indexList = new List<int>();

        //List of current letters
        private List<char> word = new List<char>();

        //constructor that initializes the dictionary
        public WordSets(string wordFile)
        {
            string[] lines = File.ReadAllLines(wordFile);

            int index = 0;

            foreach (string line in lines)
            {
                //add word to the dictionary
                Dict.Add(line);

                int wordSize = line.Length;
                //check if wordsize exists:
                if (!set.ContainsKey(wordSize))
                {
                    //if not create an entry for any word that size
                    set.Add(wordSize, new Dictionary<int, Dictionary<char, HashSet<int>>>());
                    for (int i = 0; i < wordSize; i++)
                    {
                        set[wordSize].Add(i, new Dictionary<char, HashSet<int>>());
                        foreach (char letter in alphabet)
                        {
                            set[wordSize][i].Add(letter, new HashSet<int>());
                        }
                    }
                }
                //add word to the approprate sets
                for (int i = 0; i < wordSize; i++)
                {
                    set[wordSize][i][line[i]].Add(index);
                }

                index += 1;
            }
        }

        public void SetLength(int wordLength)
        {
            length = wordLength;
            word.Clear();
            for (int i = 0; i < length; i++)
            {
                word.Add(' ');
            }
            UpdateSet();
        }

        private void UpdateSet()
        {
            List<int> newSet = new List<int>();

            //Check if word is empty
            string sWord = new string(word.ToArray());
            if (sWord.Equals("     "))
            {
                //if so go through entire list to find words
                //This process is unnessasary for a hidden list
                for (int i = 0; i < Dict.Count; i++)
                {
                    if (Dict[i].Count() == length)
                    {
                        newSet.Add(i);
                    }
                }
                indexList = newSet;
            }
            else
            {
                //Find the first letter
                int index = 0;
                while (word[index] == ' ')
                {
                    index++;
                }

                //Set the new list to the first letter's Hash
                newSet = set[length][index][word[index]].ToList();

                //Refine the set with further sets
                for (int i = index + 1; i < length; i++)
                {
                    if (word[i] != ' ')
                    {
                        newSet = UpdateHelper(newSet, i);
                    }
                }

                indexList = newSet;
            }

        }

        private List<int> UpdateHelper(List<int> partialSet, int index)
        {
            //takes a partial list and refines it into a smaller list
            List<int> returnList = new List<int>();
            foreach (int entry in partialSet)
            {
                if (set[length][index][word[index]].Contains(entry))
                {
                    returnList.Add(entry);
                }
            }
            return returnList;
        }

        public void SetLetter(int position, char letter)
        {
            //Make sure char is uppercase
            letter = Char.ToUpper(letter);

            //check if the letter is the same letter
            if (word[position] == letter)
            {
                return;
            }

            //check if the letter isn't valid
            else if (!alphabet.Contains(letter))
            {
                //remove the current value and replace with space
                word[position] = ' ';
                UpdateSet();
            }

            //check if the character being set is new
            else if (word[position] == ' ')
            {
                //Do a quick update
                word[position] = letter;
                indexList = UpdateHelper(indexList, position);
            }

            //otherwise do a complete update
            else
            {
                word[position] = letter;
                UpdateSet();
            }

        }

        public List<string> GetList()
        {
            List<string> returnList = new List<string>();
            foreach (int index in indexList)
            {
                returnList.Add(Dict[index]);
            }
            return returnList;
        }
    }
}
