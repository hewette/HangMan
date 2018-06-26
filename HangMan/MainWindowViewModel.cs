using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace HangMan
{
    public class MainWindowViewModel : BindableBase
    {
        public ICommand GameCommand { get; set; }
        public ICommand HighScoreCommand { get; set; }

        public MainWindowViewModel()
        {
            GameCommand = new DelegateCommand(ExecuteGameView, canExecuteGameView);
            HighScoreCommand = new DelegateCommand(ExecuteHighScoreCommand, canExecuteHighScoreCommand);
        }

        private bool canExecuteHighScoreCommand()
        {
            return true;
        }

        private void ExecuteHighScoreCommand()
        {
            throw new NotImplementedException();
        }

        private void ExecuteGameView()
        {
            throw new NotImplementedException();
        }

        private bool canExecuteGameView()
        {
            return true;
        }
    }
}
