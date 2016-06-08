// Adjust image to render within window
document.getElementById("sailboat").height = window.innerHeight - 20;

window.onresize = function () {
    document.getElementById("sailboat").height = window.innerHeight - 20;
}

//Create instance of sailboat
var boat = new Sailboat();
document.getElementById("calculateHullSpeed").addEventListener("click", function(event) {
    event.preventDefault();

    //Using properties on boat instance
    boat.setName(document.getElementById("name").value);
    boat.setLenght(parseInt(document.getElementById("length").value));

    //Set the result to hullspeed
    document.getElementById("result").value = boat.hullspeed().toFixed(1);
});