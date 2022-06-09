using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFNotepad.ViewModels
{
    public class HelpViewModel : OberservableObject
    {
        public ICommand HelpCommand { get; }

        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(null);
        }

        private void DisplayAbout()
        {
            //Abrir tela de ajuda

        }
    }
}
