using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace VittighederWpf
{
    class Jokes : ObservableCollection<IJoke>, INotifyPropertyChanged
    {
        public Jokes()
        {
            if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {
                // In Design mode
                Add(new Riddle("kylling1",new List<string>(new string[] {"gåde", "kylling", "plat"}),"PHP-Bog", "Hvorfor gik kyllingen over vejen", "For at komme over på den anden side"));
                Add(new Joke("bar1", new List<string>(new string[] {"bar","something", "plat"}),"internet", "Some dude walks into a bar..."));
            }
        }

        ICommand _addCommand;

        public ICommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new RelayCommand())}
        }

        private void AddJoke()
        {
            Add(new Joke());
            NotifyPropertyChanged("Count");
            CurrentIndex = Count - 1;
        }

    }
}
