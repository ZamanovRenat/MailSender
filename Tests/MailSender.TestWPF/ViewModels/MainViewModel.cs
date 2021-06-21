using System.Windows;
using System.Windows.Input;
using MailSender.TestWPF.Commands;
using MailSender.TestWPF.ViewModels.Base;

namespace MailSender.TestWPF.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {

        private string _Title = "Hello World!";

        public string Title
        {
            get => _Title;
            set
            {
                if (Set(ref _Title, value))
                    OnPropertyChanged(nameof(TitleLength));
            }
        }

        public int TitleLength => _Title.Length;

        private double _LeftPos;

        public double LeftPos
        {
            get => _LeftPos;
            set
            {
                if (Equals(_LeftPos, value)) return;
                _LeftPos = value;
                OnPropertyChanged();
            }
        }

        private double _TopPos;

        public double TopPos { get => _TopPos; set => Set(ref _TopPos, value); }

        private ICommand _ShowMessageCommand;

        public ICommand ShowMessageCommand => _ShowMessageCommand
            ??= new LambdaCommand(OnShowMessageCommandExecuted, CanShowMessageCommandExecute);

        private bool CanShowMessageCommandExecute(object p) => p != null;

        private void OnShowMessageCommandExecuted(object p)
        {
            MessageBox.Show(p.ToString());
        }
    }
}
