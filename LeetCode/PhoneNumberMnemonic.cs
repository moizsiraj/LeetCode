using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PhoneNumberMnemonic
    {
        public List<string> PhoneNumberMnemonics(string phoneNumber)
        {
            // Write your code here.
            var dictionary = new Dictionary<char, string>();
            var strings = new List<string>();
            dictionary.Add('0', "0");
            dictionary.Add('1', "1");
            dictionary.Add('2', "abc");
            dictionary.Add('3', "def");
            dictionary.Add('4', "ghi");
            dictionary.Add('5', "jkl");
            dictionary.Add('6', "mno");
            dictionary.Add('7', "pqrs");
            dictionary.Add('8', "tuv");
            dictionary.Add('9', "wxyz");

            GetPermutations(dictionary, strings, new char[phoneNumber.Length], 0, phoneNumber); ;
            return strings;
        }

        private void GetPermutations(Dictionary<char, string> dictionary, List<string> strings, char[] list, int index, string phoneNumber)
        {
            if (index == phoneNumber.Length)
            {
                var str = new StringBuilder();
                list.ToList().ForEach(chr => str.Append(chr));
                strings.Add(str.ToString());
                return;
            }

            //Get all the letters for the given number
            var letters = dictionary[phoneNumber[index]];

            //one by one place each letter on the index
            foreach (var letter in letters)
            {
                list[index] = letter;
                //make recursive call for the next index
                GetPermutations(dictionary, strings, list, index + 1, phoneNumber);
            }
        }
    }
}