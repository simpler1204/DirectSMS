

using CommunityToolkit.Mvvm.ComponentModel;

namespace DirectSMS.Models;

public partial class SmsTarget : ObservableObject
{
    [ObservableProperty]
    private string _name = string.Empty;
    [ObservableProperty]
    private string _phoneNumber = string.Empty;
    [ObservableProperty]
    private string _status = "대기";


}
