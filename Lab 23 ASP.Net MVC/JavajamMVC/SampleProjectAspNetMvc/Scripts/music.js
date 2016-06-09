//$(".toggler").position({
//    my: "center",
//    at: "center",
//    of: "#content"
//});

////Modal dialog with picture - not open when loaded
//$("#melanie").dialog({ autoOpen: true, modal: true, title: "Melanie Morris" });

////Melanie dialog opens when thumbnail is clicked.
//$("#melaniethumb").click(function (event) {
//    event.preventDefault();
//    $("#melanie").dialog("open");
//});


////Hide Greg when clicking
//$("#greg").click(function () { $("#greg").hide(); });

////Hides Greg as environement is loaded
//$("#greg").hide();

////Show Greg when clicking the thumbnail. Greg fading out
//$("#gregthumb").click(function () {
//    $("#greg").show().fadeOut(7000);
//    return false;
//});

// music.js

// Melanie
// Laver billedet til en modal dialog ved brug af jQuery UI (kræver også jquery.ui.all.css for at få den rette finish).
$("#malanie").dialog({ autoOpen: false, modal: true, title: "Melanie Morris" });
$('#melaniethumb').click(function (event) {
    event.preventDefault();
    $("#malanie").dialog('open');
});

// Greg
// Bruger absolute positionering til at vise billedet foran content og centreret og hide/show til at skjule/vise billedet.
$(".toggler").position({
    my: "center",
    at: "center",
    of: "#content"
});
$('#greg').click(function () { $("#greg").hide(); });
$("#greg").hide();
$('#gregthumb').click(function () {
    $("#greg").show().fadeOut(7000); return false;
});