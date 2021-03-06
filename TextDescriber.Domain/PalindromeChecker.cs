﻿namespace TextDescriberDomain
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                return false;
            }
            var inputTextWithNoSpaces = inputText.Replace(" ", "");
            var indexFromStart = 0;
            var indexFromEnd = inputTextWithNoSpaces.Length - 1;
            while (indexFromStart < indexFromEnd)
            {
                if (inputTextWithNoSpaces[indexFromStart] != inputTextWithNoSpaces[indexFromEnd])
                {
                    return false;
                }
                indexFromStart++;
                indexFromEnd--;
            }
            return true;
        }
    }
}
