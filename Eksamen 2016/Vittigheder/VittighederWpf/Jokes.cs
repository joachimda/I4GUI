using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;
using Newtonsoft.Json;

namespace VittighederWpf
{
    public class Jokes : ObservableCollection<Joke>
    {
        /*Path declaration for json file - File in User/Documents*/
        private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\wpfData.json";

        #region Dummy data generation

        public void GenerateDummyData(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Add(new Joke("kylling1", new List<string>(new string[] { "gåde", "kylling", "plat" }), "PHP-Bog", "Hvorfor gik kyllingen over vejen", "For at komme over på den anden side"));
                Add(new Joke("bar1", new List<string>(new string[] { "bar", "something", "plat" }), "internet", "Some dude walks into a bar..."));
            }
        }

        #endregion

        #region Add joke to collection

        ICommand _addCommand;

        public ICommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new RelayCommand(AddJoke)); }
        }

        private void AddJoke()
        {
            AddDialog dialog = new AddDialog();

            if (dialog.ShowDialog() == true)
            {
                string[] tagArray = dialog.JokeTagsUnified.Split(',');

                List<string> tagsList = new List<string>();

                foreach (var item in tagArray)
                {
                    tagsList.Add(item);
                }

                Add(new Joke(dialog.JokeName, tagsList, dialog.JokeAuthor, dialog.JokeSetup, dialog.JokePunchline));
            }
        }

        #endregion

        #region Load with Json Deserialize
        ICommand _loadCommand;

        public ICommand LoadCommand
        {
            get
            {
                return _loadCommand ?? (_loadCommand = new RelayCommand(LoadFileCommand_Execute));
            }
        }

        private void LoadFileCommand_Execute()
        {
            if (!File.Exists(_path))
            {
                MessageBox.Show("No saved jokes was found.", "No file", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string jsonIn = "";
            Jokes jokes = null;
            try
            {
                jsonIn = File.ReadAllText(_path);
                jokes = JsonConvert.DeserializeObject<Jokes>(jsonIn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Clear();

            foreach (Joke joke in jokes)
            {
                Add(joke);
            }

        }
        #endregion

        #region Save with Json Serialize

        ICommand _SaveCommand;

        public ICommand SaveCommand
        {
            get { return _SaveCommand ?? (_SaveCommand = new RelayCommand(SaveFileCommand_Execute)); }
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

        #endregion
    }
}
