using HackatonProject.Views;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class CreateConferenceViewModel : BaseViewModel
    {
        public string RoomTitle { get; set; }
        public ICommand CreateConferenceCommand { get; set; }

        public CreateConferenceViewModel()
        {
            CreateConferenceCommand = new Command(CreateConference);
            CheckPermissionsAndStart();
        }

        private void CreateConference()
        {
            DependencyService.Get<INavigation>().PushAsync(new MultiRoomView(RoomTitle));
        }

        private string _roomName;

        public string RoomName
        {
            get => _roomName;
            set => SetProperty(ref _roomName, value);
        }

        private async Task CheckPermissionsAndStart()
        {
            if (Device.RuntimePlatform != Device.macOS)
            {
                List<Permission> permissionsToRequest = new List<Permission>();
                PermissionStatus cameraPermissionState = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
                if (cameraPermissionState != PermissionStatus.Granted)
                {
                    permissionsToRequest.Add(Permission.Camera);
                }

                PermissionStatus microphonePermissionState = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Microphone);
                if (microphonePermissionState != PermissionStatus.Granted)
                {
                    permissionsToRequest.Add(Permission.Microphone);
                }

                if (permissionsToRequest.Count > 0)
                {
                    await CrossPermissions.Current.RequestPermissionsAsync(permissionsToRequest.ToArray());
                }
            }
        }
    }
}