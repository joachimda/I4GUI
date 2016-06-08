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