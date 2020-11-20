    function runQrScanner(canvasElement,videoElement,outputElement,loadingMessageElement,qrCodeScannerRef) {

 
        var video = videoElement;


    var canvas = canvasElement.getContext("2d");
    
        var idRequestAnimation;


    // Use facingMode: environment to attemt to get the front camera on phones
    navigator.mediaDevices.getUserMedia({ video: { facingMode: "environment" } }).then(function(stream) {
      video.srcObject = stream;
      video.setAttribute("playsinline", true); // required to tell iOS safari we don't want fullscreen
      video.play();
      idRequestAnimation = requestAnimationFrame(tick);
    });

    function tick() {
        loadingMessageElement.innerText = "⌛ Loading video...";
      if (video.readyState === video.HAVE_ENOUGH_DATA) {
      

        canvas.drawImage(video, 0, 0, canvasElement.width, canvasElement.height);
        var imageData = canvas.getImageData(0, 0, canvasElement.width, canvasElement.height);
        var code = jsQR(imageData.data, imageData.width, imageData.height, {
          inversionAttempts: "dontInvert",
        });
        if (code) {
        
            video.pause();
            qrCodeScannerRef.invokeMethod('HaveScanResult', code.data);
            window.cancelAnimationFrame(idRequestAnimation);

    
        }
      }
        idRequestAnimation = requestAnimationFrame(tick);
    }
}

    function runQrScannerFromFile(canvasElement, fileElement, qrCodeScannerRef) {

        var canvas = canvasElement.getContext("2d");
        var img = new Image;
        img.onload = function () {
            canvas.drawImage(img, 0, 0, canvasElement.width, canvasElement.height);

            console.log("image is draw");

            var imageData = canvas.getImageData(0, 0, canvasElement.width, canvasElement.height);

        

            var code = jsQR(imageData.data, imageData.width, imageData.height, {
                inversionAttempts: "dontInvert"
            });

            if (code) {
                qrCodeScannerRef.invokeMethod('HaveScanResultForFile', code.data);

            }
            else {
                qrCodeScannerRef.invokeMethod('DontHaveScanResultForFile');
            }
        };


        img.src = URL.createObjectURL(fileElement.files[0]);

       
   

      
}




function addClickEvent(targetElement) {
    console.log("event");

        targetElement.click();
  
}
