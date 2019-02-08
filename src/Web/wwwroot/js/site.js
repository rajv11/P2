// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function bmi() {
    var weight = document.getElementById("weight").value * 0.45;
    var height = document.getElementById("heightFt").value * 12 * 0.025;
    var bmi = weight / (height * height);
    alert("Your BMi is " + Math.round(bmi * 10)/10);
}