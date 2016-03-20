using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EncryptorCore.Interface;

namespace EncryptorCore
{
    public class SimpleEncryption : IEncryption
    {
        private readonly string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private int AlphabetLength { get; set; }

        public SimpleEncryption()
        {
            AlphabetLength = Alphabet.Length;
        }
        private string  InputText { get; set; }

        private string InputWord { get; set; }

        private string OutputText { get; set; }
        public string EncryptWord(string inputWord)
        {
            InputWord = inputWord;
            var wordLength = InputWord.Length;
            var outputText = string.Empty;

            // Shift english alphabet to the right by wordLength

            foreach (var letter in InputWord)
            {
                var originalIndex = Alphabet.IndexOf(letter);
                var finalIndex = (originalIndex + wordLength)%AlphabetLength;
                var finalLetter = Alphabet[finalIndex];
                outputText += finalLetter;
            }

            return outputText;
        }

        public string EncryptText(string inputText)
        {
            InputText = inputText;

            OutputText = Regex.Replace(InputText, @"[A-Za-z]+", m => EncryptWord(m.Value));

            return OutputText;
        }
    }
}