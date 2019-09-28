using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazoredDemoApp.Pages
{
    public class ToastDemoBase : ComponentBase, IDisposable
    {
        CancellationTokenSource cancelationTokenSource = new CancellationTokenSource();

        [Inject]
        public IToastService toastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await foreach (var d in GetDatesAsync().WithCancellation(cancelationTokenSource.Token))
            {
                ValidationMessage<int> v;

                Console.WriteLine(d);
                toastService.ShowInfo("x " + d);
            }
        }

        public async IAsyncEnumerable<DateTime> GetDatesAsync()
        {
            while (!cancelationTokenSource.IsCancellationRequested)
            {
                await Task.Delay(5000, cancelationTokenSource.Token);
                yield return DateTime.Now;
            }
        }

        public void Dispose()
        {
            cancelationTokenSource.Cancel();
            Console.WriteLine("done");
        }
    }
}