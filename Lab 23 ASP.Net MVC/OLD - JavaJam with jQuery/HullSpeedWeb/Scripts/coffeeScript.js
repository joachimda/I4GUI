var menu = document.getElementsByClassName("menu");
for (i = 0; i < menu.length; i++) {
    menu[i].addEventListener("mouseover", function (event) {
        var target = event.target || event.srcElement;
        target.className = "menuEnhanced"
    });
    menu[i].addEventListener("mouseout", function (event) {
        var target = event.target || event.srcElement;
        target.className = "menu";
    });
};

//Append lastModified with jQuery
$("footer").append("<p>This page was last modified on: " + document.lastModified + "</p>");


//Place greg in the center
$(".toggler").position({
    my: "center",
    at: "center",
    of: "#content"
});

//Modal dialog with picture - not open when loaded
$("#melanie").dialog({ autoOpen: true, modal: true, title: "Melanie Morris" });

//Melanie dialog opens when thumbnail is clicked.
$("#melaniethumb").click(function (event) {
    event.preventDefault();
    $("#melanie").dialog("open");
});


//Hide Greg when clicking
$("#greg").click(function () { $("#greg").hide(); });

//Hides Greg as environement is loaded
$("#greg").hide();

//Show Greg when clicking the thumbnail. Greg fading out
$("#gregthumb").click(function () {
    $("#greg").show().fadeOut(7000);
    return false;
});

