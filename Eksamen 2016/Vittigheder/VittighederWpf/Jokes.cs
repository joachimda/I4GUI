using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
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

        /// <summary>
        /// Generates dummy data
        /// </summary>
        /// <param name="amount"></param>
        public void GenerateDummyData(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Add(new Joke("Kyllinge Joke1", new List<string>(new string[] { "gåde", "kylling" }), "PHP-Bog", "Hvorfor gik kyllingen over vejen?", "For at komme over på den anden side"));
                Add(new Joke("Kyllinge Joke2", new List<string>(new string[] { "gåde", "kylling", "kalkun" }), "Arthur", "Hvorfor gik kalkunen over vejen?", "Fordi det var kyllingens fridag."));
                Add(new Joke("Kyllinge Joke3", new List<string>(new string[] { "gåde", "kylling", "fasan" }), "Sofie", "Hvorfor gik fasanen over vejen?", "For at bevise at den ikke var en kylling."));
                Add(new Joke("Kyllinge Joke4", new List<string>(new string[] { "gåde", "kylling", "matematik" }), "Wikipedia", "Hvorfor gik kyllingen over Möbius bånd?", "For at komme over på den samme side."));
                Add(new Joke("Bar Joke1", new List<string>(new string[] { "bar", "something", "plat" }), "internet", "Someone walks into a bar..."));
            }
        }

        #endregion

        #region Add joke to collection

        private ICommand _addCommand;

        public ICommand AddCommand => _addCommand ?? (_addCommand = new RelayCommand(AddJoke));

        private void AddJoke()
        {
            AddDialog dialog = new AddDialog();

            if (dialog.ShowDialog() != true) return;
            string[] tagArray = dialog.JokeTagsUnified.Split(',');

            List<string> tagsList = tagArray.ToList();

            Add(new Joke(dialog.JokeName, tagsList, dialog.JokeAuthor, dialog.JokeSetup, dialog.JokePunchline));
        }

        #endregion

        #region Load with Json Deserialize

        private ICommand _loadCommand;

        public ICommand LoadCommand => _loadCommand ?? (_loadCommand = new RelayCommand(LoadFileCommand_Execute));

        private void LoadFileCommand_Execute()
        {
            if (!File.Exists(_path))
            {
                MessageBox.Show("No saved jokes was found.", "No file", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Jokes jokes = null;
            try
            {
                var jsonIn = File.ReadAllText(_path);
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

        ICommand _saveCommand;

        public ICommand SaveCommand => _saveCommand ?? (_saveCommand = new RelayCommand(SaveFileCommand_Execute));

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
