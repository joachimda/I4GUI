using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace VittighederWpf
{
    class Jokes : ObservableCollection<Joke>, INotifyPropertyChanged
    {
        private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\wpfData.json";

        public Jokes()
        {
            //if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {
                // In Design mode
                Add(new Joke("kylling1", new List<string>(new string[] { "gåde", "kylling", "plat" }), "PHP-Bog", "Hvorfor gik kyllingen over vejen", "For at komme over på den anden side"));
                Add(new Joke("bar1", new List<string>(new string[] { "bar", "something", "plat" }), "internet", "Some dude walks into a bar..."));
            }
        }

        ICommand _addCommand;
        ICommand _SaveCommand;
        ICommand _loadCommand;

        public ICommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new RelayCommand(AddJoke)); }
        }

        private void AddJoke()
        {
            AddDlg dlg = new AddDlg();

            if (dlg.ShowDialog() == true)
            {
                string[] tagArray = dlg.JokeTagsUnified.Split(',');

                List<string> tagsList = new List<string>();

                foreach (var item in tagArray)
                {
                    tagsList.Add(item);
                }

                Add(new Joke(dlg.JokeName, tagsList, dlg.JokeAuthor,dlg.JokeSetup, dlg.JokePunchline));
                NotifyPropertyChanged("Count");
                CurrentIndex = Count - 1;
            }
        }

        public ICommand LoadCommand { get
        {
            return _loadCommand ?? (_loadCommand = new RelayCommand(LoadFileCommand_Execute));}
        }
        
        public ICommand SaveCommand
        {
            get { return _SaveCommand ?? (_SaveCommand = new RelayCommand(SaveFileCommand_Execute)); }
        }

        private void LoadFileCommand_Execute()
        {
            
        }

        private void SaveFileCommand_Execute()
        {
            string jsonOut = JsonConvert.SerializeObject(this);
            using (StreamWriter streamWriter = new StreamWriter(_path))
            {
                streamWriter.Write(jsonOut);
                streamWriter.Close();
            }
        }

        #region Properties
        int currentIndex = -1;
        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                if (currentIndex != value)
                {
                    currentIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion 

        public new event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
