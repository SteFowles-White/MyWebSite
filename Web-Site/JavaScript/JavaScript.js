function OpenNavMenu() {
    //cget the element
    const openTab = document.getElementById("MenuTab");
    //see if class w3-show is in the field
    if (openTab.className.indexOf("w3-show") == -1) {
        // if not add it to open the menu
        openTab.className += " w3-show";
    } else {
        //if it is then remove it to close the window
        openTab.className = openTab.className.replace(" w3-show", "");
    }
};