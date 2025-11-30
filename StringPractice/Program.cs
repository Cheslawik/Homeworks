using System.Text.RegularExpressions;

namespace StringPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Wow! This is my 1st tsest. Do you see number42? Yes! " +
                            "Otto ran to room101. Anna loves level99. " +
                            "Are you ready? No, I am not! " +
                            "This sentence has no comma. But this one, definitely has a comma, right? " +
                            "Hey! Look at Bob — he found 777 coins! " +
                            "Is 12345 the longest digit-word? Maybe! " +
                            "Otto said: \"Wow!\" Anna replied: \"Yes!\" " +
                            "Final test. Donenod!";
            while (true)
            {
                Console.WriteLine("Chose the operation: " +
                    "\n1 - Find the words that contain the largest number of digits;" +
                    "\n2 - Find the longest word and determine how many times it appears in the text;" +
                    "\n3 - Replace the digits from 0 to 9 with the words 'zero', 'one', ..., 'nine'" +
                    "\n4 - Display interrogative sentences first, and then exclamatory sentences;" +
                    "\n5 - Display only the sentences that do not contain commas;" +
                    "\n6 - Find the words that begin and end with the same letter;" +
                    "\n7 - Searching in text;" +
                    "\n8 - Display palindromes, if there are any;" +
                    "\n0 - close the program.\n");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        FindWordsWithMostDigits(text);
                        break;
                    case "2":
                        FindLongestWordAndCount(text);
                        break;
                    case "3":
                        ReplaceDigitsWithWords(text);
                        break;
                    case "4":
                        DisplayInterrogativeAndExclamatorySentences(text);
                        break;
                    case "5":
                        DisplaySentencesWithoutCommas(text);
                        break;
                    case "6":
                        FindWordsStartingAndEndingWithSameLetter(text);
                        break;
                    case "7":
                        SearchByInput(text);
                        break;
                    case "8":
                        DisplayPolindromes(text);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            static string[] SplitTextIntoWords(string text)
            {
                char[] delimiteres = new char[] { ' ', '\r', '\n', '.', ',', '!', '?', '-', '—', ':', ';', '\"', '(', ')' };
                string[] words = text.Split(delimiteres, StringSplitOptions.RemoveEmptyEntries);

                return words;
            }

            static string[] SplitTextIntoSentences(string text)
            {
                //char[] delimiteres = new char[] { '.', '!', '?' };
                //string[] sentences = text.Split(delimiteres, Str);
                string[] sentences = Regex.Split(text, @"(?<=[.!?])\s+");
                return sentences;
            }

            static void FindWordsWithMostDigits(string text)
            {
                string[] words = SplitTextIntoWords(text);
                int maxDigitCount = 0;
                string wordWithMostDigits = "";

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Any(char.IsDigit) && words[i].Any(char.IsLetter))
                    {
                        int digitCount = 0;
                        foreach (char c in words[i])
                        {
                            if (char.IsDigit(c))
                            {
                                digitCount++;
                            }
                            else
                            {
                                continue;
                            }
                            if (digitCount > maxDigitCount)
                            {
                                maxDigitCount = digitCount;
                                wordWithMostDigits = words[i];
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine($"The word with the most digits {wordWithMostDigits} has {maxDigitCount} digits.");
            }

            static void FindLongestWordAndCount(string text)
            {
                string[] words = SplitTextIntoWords(text);
                int wordWithMaxLength = 0;
                string longestWord = "";

                for (int i = 0; i < words.Length; i++)
                {
                    int letterCount = 0;
                    foreach (char c in words[i])
                    {
                        letterCount++;
                    }
                    if (letterCount > wordWithMaxLength)
                    {
                        wordWithMaxLength = letterCount;
                        longestWord = words[i];
                    }
                }
                Console.WriteLine($"The longest word is {longestWord.ToUpper()} has {wordWithMaxLength} letters.");

            }

            static void ReplaceDigitsWithWords(string text)
            {
                Dictionary<int, string> digitWords = new Dictionary<int, string>
                {
                    {0, "zero"},
                    {1, "one"},
                    {2, "two"},
                    {3, "three"},
                    {4, "four"},
                    {5, "five"},
                    {6, "six"},
                    {7, "seven"},
                    {8, "eight"},
                    {9, "nine"}
                };

                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsDigit(text[i]))
                    {
                        int digit = (int)char.GetNumericValue(text[i]); //получаю числовое значение символа
                        text = text.Replace(text[i].ToString(), digitWords[digit]); //заменяю символ на слово из словаря
                    }
                }
                Console.WriteLine($"{text}");
            }

            static void DisplayInterrogativeAndExclamatorySentences(string text)
            {
                string[] sentences = SplitTextIntoSentences(text);
                List<string> interrogativeSentences = new List<string>();
                List<string> exclamatorySentences = new List<string>();
                for (int i = 0; i < sentences.Length; i++)
                {
                    if (sentences[i].EndsWith("?"))
                    {
                        interrogativeSentences.Add(sentences[i]);
                    }
                    else if (sentences[i].EndsWith("!"))
                    {
                        exclamatorySentences.Add(sentences[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
                foreach (string sentence in interrogativeSentences)
                {
                    Console.WriteLine(sentence);
                }
                foreach (string sentence in exclamatorySentences)
                {
                    Console.WriteLine(sentence);
                }
            }

            static void DisplaySentencesWithoutCommas(string text)
            {
                string[] sentences = SplitTextIntoSentences(text);
                List<string> sentencesNoCommas = new List<string>();
                for (int i = 0; i < sentences.Length; i++)
                {
                    if (sentences[i].Contains(","))
                    {
                        continue;
                    }
                    else
                    {
                        sentencesNoCommas.Add(sentences[i]);
                    }
                }
                foreach (string sentence in sentencesNoCommas)
                {
                    Console.WriteLine(sentence);
                }
            }

            static void FindWordsStartingAndEndingWithSameLetter(string text)
            {
                string[] words = SplitTextIntoWords(text);
                List<string> wordsWithSameStartEndsLetter = new List<string>();
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    if (word.Length > 1 &&
                        char.ToLowerInvariant(word[0]) == char.ToLowerInvariant(word[word.Length - 1]))
                    {
                        wordsWithSameStartEndsLetter.Add(word);
                    }
                }
                foreach (var w in wordsWithSameStartEndsLetter)
                {
                    Console.WriteLine(w);
                }
            }

            static void SearchByInput(string text)
            {
                Console.Write("Enter what you wanna find: ");
                string input = Console.ReadLine();
                string[] words = SplitTextIntoWords(text);
                List<string> foundWords = new List<string>();
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains(input, StringComparison.OrdinalIgnoreCase))
                    {
                        foundWords.Add(words[i]);
                    }
                }
                foreach (var f in foundWords)
                {
                    Console.WriteLine(f);
                }
            }

            static void DisplayPolindromes(string text)
            {
                string[] words = SplitTextIntoWords(text);
                List<string> palindromes = new List<string>();
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    string reversedWord = new string(word.Reverse().ToArray());
                    if (string.Equals(word, reversedWord, StringComparison.OrdinalIgnoreCase) && word.Length > 1)
                    {
                        palindromes.Add(word);
                    }
                }
                if (palindromes.Count > 0)
                {
                    Console.WriteLine("Palindromes found:");
                    foreach (var p in palindromes)
                    {
                        Console.WriteLine(p);
                    }
                }
                else
                {
                    Console.WriteLine("No palindromes found.");
                }
            }
        }
    }
}
