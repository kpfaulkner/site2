using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace site2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DisplayWord : Page
    {
        List<WordEntry> WordList = new List<WordEntry>();
        int currentWordIndex = 0;


        public DisplayWord()
        {
            this.InitializeComponent();
            LoadWordList();
        }


        private void LoadWordList()
        {

            WordList.Clear();

            WordList.Add(new WordEntry() { Word = "I" });
            WordList.Add(new WordEntry() { Word = "am" });
            WordList.Add(new WordEntry() { Word = "mum" });
            WordList.Add(new WordEntry() { Word = "is" });
            WordList.Add(new WordEntry() { Word = "dad" });
            WordList.Add(new WordEntry() { Word = "here" });
            WordList.Add(new WordEntry() { Word = "a" });
            WordList.Add(new WordEntry() { Word = "big" });
            WordList.Add(new WordEntry() { Word = "little" });
            WordList.Add(new WordEntry() { Word = "in" });
            WordList.Add(new WordEntry() { Word = "the" });
            WordList.Add(new WordEntry() { Word = "we" });
            WordList.Add(new WordEntry() { Word = "go" });
            WordList.Add(new WordEntry() { Word = "to" });
            WordList.Add(new WordEntry() { Word = "come" });
            WordList.Add(new WordEntry() { Word = "and" });
            WordList.Add(new WordEntry() { Word = "see" });
            WordList.Add(new WordEntry() { Word = "like" });
            WordList.Add(new WordEntry() { Word = "she" });
            WordList.Add(new WordEntry() { Word = "up" });

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            WordButton.Content = WordList[currentWordIndex].Word;
        }

        private void WordButton_Click(object sender, RoutedEventArgs e)
        {
            currentWordIndex++;
            if (currentWordIndex >= WordList.Count)
            {
                currentWordIndex = 0;
            }

            WordButton.Content = WordList[currentWordIndex].Word;
        }
    }
}
