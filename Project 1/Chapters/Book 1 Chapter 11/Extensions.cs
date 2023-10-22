using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Chapters.Book_1_Chapter_11
{
    static class Extensions
    {
        public static string CharArray(this string str)
        {
            string output = "";
            char[] chars = new char[str.Length];
            try
            {
                for (int i = 0; i < str.Length; i++) { chars[i] = str[i]; }
                foreach (char c in chars) { output += c + " , "; }
                output = output.Remove(output.Length - 3, 2);
            }
            catch { output = "Enter some text!"; }
            return output;
        }

        public static string DateSplitter(this string str)
        {
            string output = "";
            char[] delim = { '/' };
            string[] tokens = str.Split(delim);
            if (tokens.Length == 3)
            { output = "Month " + tokens[0] + ", Day " + tokens[1] + ", Year " + tokens[2]; }
            else output = "Don't forget to seperate it MM/DD/YYYY";
            return output;
        }

        public static bool PhoneNumberValidator(this string str)
        {
            const int VALID_LENGTH = 10;
            bool valid = true;
            if (str.Length == VALID_LENGTH)
            {
                foreach (char c in str)
                {
                    if (!char.IsDigit(c)) { valid = false; }
                }
            }
            else { valid = false; }
            return valid;
        }

        public static string PhoneNumberFormatter(this string str)
        {
            str = str.Insert(0, "(");
            str = str.Insert(4, ")");
            str = str.Insert(8, "-");
            return str;
        }

        public static string Backwards(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string WordCounter(this string str)
        {
            string output = "";
            str.Trim();
            int count = 0;
            char[] delim = { ' ' };
            string[] tokens = str.Split(delim);
            foreach (string s in tokens)
            {
                if (s != "")
                {
                    if (char.IsLetter(s, 0)) { count += 1; }
                }
                else { output = "Enter some words.."; }
            }
            if (count == 1) { output = "There is only 1 word."; }
            else if (count > 1) { output = "There are " + count + " words."; }
            return output;
        }
    }
}
