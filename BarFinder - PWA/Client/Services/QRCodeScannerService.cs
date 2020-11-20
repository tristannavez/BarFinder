using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Gimli.Client.Services
{
    public class QRCodeScannerService
    {

        private IJSInProcessRuntime _jsRuntime;

        public QRCodeScannerService(IJSRuntime jsRuntime)
        {

            _jsRuntime = (IJSInProcessRuntime)jsRuntime;
        }

        public async Task RunScanner()
        {

             await _jsRuntime.InvokeVoidAsync("runQrScanner");


        }


    }


}
