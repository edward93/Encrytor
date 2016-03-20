using System.Text.RegularExpressions;
using EncryptorCore.Interface;

namespace EncryptorCore
{
    public class SimpleDecryption: IDecryption
    {
        private readonly string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private string InputText { get; set; }
        private string OutputText { get; set; }

        private int AlphabetLength { get; set; }

        public SimpleDecryption()
        {
            AlphabetLength = Alphabet.Length;
        }
        public string DecryptWord(string inputWord)
        {
            InputText = inputWord;
            var wordLength = InputText.Length;
            var outputText = string.Empty;

            // Shift alphabet to the left by wordLength

            foreach (var letter in InputText)
            {
                var originalIndex = Alphabet.IndexOf(letter);
                var shift = originalIndex - wordLength >= 0
                    ? originalIndex - wordLength
                    : AlphabetLength + (originalIndex - wordLength);
                var finalIndex = shift % AlphabetLength;
                var finalLetter = Alphabet[finalIndex];
                outputText += finalLetter;
            }

            return outputText;
        }

        public string DecryptText(string inputText)
        {
            InputText = inputText;

            OutputText = Regex.Replace(InputText, @"[A-Za-z]+", m => DecryptWord(m.Value));

            return OutputText;
        }
    }
}