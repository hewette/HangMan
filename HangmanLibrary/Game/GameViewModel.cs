using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace HangmanLibrary.Game
{
    public class GameViewModel : BindableBase
    {
        public ICommand StartCommand { get; set; }

        public GameViewModel()
        {
            StartCommand = new DelegateCommand(ExecuteStartCommand, canExecute);
        }

        private bool canExecute()
        {
            return true;
        }

        private void ExecuteStartCommand()
        {
            throw new NotImplementedException();
        }
    }
}
