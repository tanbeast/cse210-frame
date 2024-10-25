class Word
    {
        private string Text { get; set; }
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        // Hide the word
        public void Hide()
        {
            IsHidden = true;
        }

        // Get the text to display (hidden or shown)
        public string GetDisplayText()
        {
            if (IsHidden)
            {
                return new string('_', Text.Length);
            }
            else
            {
                return Text;
            }
        }
    }