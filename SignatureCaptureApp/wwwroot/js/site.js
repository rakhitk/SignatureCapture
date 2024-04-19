// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    var canvas = document.getElementById('signatureCanvas');
    var signaturePad = new SignaturePad(canvas);

    document.getElementById('clearButton').addEventListener('click', function () {
        signaturePad.clear();
    });

    document.getElementById('signatureForm').addEventListener('submit', function (e) {
        e.preventDefault();

        if (signaturePad.isEmpty()) {
            alert('Please provide a signature.');
        } else {
            var signatureData = signaturePad.toDataURL(); // Get the signature as base64 encoded image data
            console.log(signatureData, 'formData');
        }
    });
});