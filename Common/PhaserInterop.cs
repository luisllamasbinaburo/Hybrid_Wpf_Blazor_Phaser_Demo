using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace WpfBlazor.Common
{
    public class PhaserInterop
    {
        public async Task Init(IJSRuntime js)
        {            
            var objectRef = DotNetObjectReference.Create(this);
            await js.InvokeVoidAsync("init", objectRef);
        }

        [JSInvokable]
        public async Task OnPhaserLoaded()
        {
        }
    }
}
