using CommunityToolkit.WinUI.Notifications;

using DatPhat3.Contracts.Services;

using Windows.UI.Notifications;

namespace DatPhat3.Services;

public partial class ToastNotificationsService : IToastNotificationsService
{
    public ToastNotificationsService()
    {
    }

    public void ShowToastNotification(ToastNotification toastNotification)
    {
        ToastNotificationManagerCompat.CreateToastNotifier().Show(toastNotification);
    }
}
