using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
    {
        private Reference Reference { get; set; }
        private List<Word> Words { get; set; }

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        
        public void Display()
        {
            Console.WriteLine(Reference.ToString());
            Console.WriteLine(string.Join(" ", Words.Select(word => word.GetDisplayText())));
        }

        public void HideRandomWords()
        {
            Random random = new Random();
            int wordsToHide = random.Next(2, 4); 
            List<Word> visibleWords = Words.Where(word => !word.IsHidden).ToList();
            for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index); 
            }
        }

        public bool AllWordsHidden()
        {
            return Words.All(word => word.IsHidden);
        }
    }