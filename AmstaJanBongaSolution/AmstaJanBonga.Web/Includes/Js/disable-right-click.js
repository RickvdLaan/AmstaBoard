document.oncontextmenu = RightMouseDown;
document.onmousedown = mouseDown;

function mouseDown(e) {
    if (e.which == 3) {
        return false;
    }
}

function RightMouseDown() {
    return false;
}