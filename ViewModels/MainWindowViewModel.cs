using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using DirectSMS.Models;

namespace DirectSMS.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<SmsTarget> Targets { get; } = new();

    public MainWindowViewModel()
    {
        Targets.Add(new SmsTarget { Name = "홍길동", PhoneNumber = "010-1111-2222" });
    }

    [RelayCommand]
    private void SendSms()
    {

    }
}

