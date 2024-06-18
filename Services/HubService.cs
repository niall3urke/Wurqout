using Microsoft.AspNetCore.SignalR.Client;
using System.Diagnostics.Contracts;

namespace Wurqout.Services
{
    public class HubService
    {

        private readonly HubConnection hubConnection;

        public Action<string> OnReceiveData;

        // Constructors

        public HubService(string hubUrl)
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl(hubUrl)
                .Build();

            hubConnection.On<string>("ReceiveData", data =>
            {
                OnReceiveData?.Invoke(data);
            });
        }

        // Methods

        public async Task StartConnectionAsync()
        {
            await hubConnection.StartAsync();
        }

        public async Task JoinGroupAsync(string groupName)
        {
            await hubConnection.InvokeAsync("JoinGroup", groupName);
        }

        public async Task SendDataAsync(string groupName, string data)
        {
            await hubConnection.InvokeAsync("SendData", groupName, data);
        }


    }
}
