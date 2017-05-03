using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileSystem.WPF
{


    public class MianViewModel : Model
    {
        private string FSelectedFilePath = string.Empty;
        private string FKeywordToSearch = string.Empty;
        private string FSearchResult = string.Empty;

        public string SelectedFilePath
        {
            get { return FSelectedFilePath; }
            set
            {
                SetProperty(ref FSelectedFilePath, value);
            }
        }

        public string KeywordToSearch
        {
            get { return FKeywordToSearch; }
            set
            {
                SetProperty(ref FKeywordToSearch, value);
            }
        }

        public string SearchResult
        {
            get { return FSearchResult; }
            set
            {
                SetProperty(ref FSearchResult, value);
            }
        }

        public ICommand BrowserFileCommand { get; private set; }
        public ICommand SearchKeywordCommand { get; private set; }

        public MianViewModel()
        {
            BrowserFileCommand = new DelegateCommand(BrowserFileAction);
            SearchKeywordCommand = new DelegateCommand(SearchKeywordAction);
        }

        private void BrowserFileAction()
        {
            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            folderBrowserDialog.ShowDialog();

            SelectedFilePath = folderBrowserDialog.FileName;
        }

        private void SearchKeywordAction()
        {
            KeywordFinder finder = new KeywordFinder();
            int matchedNumber = finder.FindMatchedKeyword(SelectedFilePath, KeywordToSearch);

            SearchResult = matchedNumber + " keyword find in the file.";
        }
    }
}
