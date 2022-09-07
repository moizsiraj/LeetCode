using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BinaryAdd
    {
        private char _Carry = '0';
        private StringBuilder builder = new();

        //My Approach
        //process in loop for the length of smaller one
        //process remaining in another loop

        //Another Approach
        //process in loop for the larger string length
        //add check if smaller index < 0 pass 0 in Add function
        
        //1 Hour
        public string Solve(string a, string b) 
        { 
            var AisLarger = a.Length > b.Length;
            var runFor = AisLarger ? b.Length : a.Length;
            var persistRunFor = runFor;

            for (int i = a.Length - 1, j = b.Length - 1 ; runFor > 0; runFor--, i--, j--)
            {
                var (value, carry) = Add(a.ElementAt<char>(i), b.ElementAt<char>(j));
                builder.Insert(0, value);
                _Carry = carry;
            }

            if (AisLarger)
                ProcessRemaining(a, persistRunFor);
            else
                ProcessRemaining(b, persistRunFor);
            

            if (_Carry == '1')
                builder.Insert(0, '1');

            return builder.ToString();
        }

        private void ProcessRemaining(string b, int persistRunFor)
        {
            for (int i = b.Length - persistRunFor - 1; i >= 0; i--)
            {
                var (value, carry) = Add(b.ElementAt<char>(i), '0');
                builder.Insert(0, value);
                _Carry = carry;
            }
        }

        private (char value, char carry) Add(char fromA, char fromB) 
        {
            if ((int)fromA + (int)fromB + (int)_Carry == 49 * 3)
                return ('1', '1');
            else if ((int)fromA + (int)fromB + (int)_Carry == ((49 * 2) + 48))
                return ('0', '1');
            else if ((int)fromA + (int)fromB + (int)_Carry == ((48 * 2) + 49))
                return ('1', '0');
            else
                return ('0', '0');
        }
    }
}
