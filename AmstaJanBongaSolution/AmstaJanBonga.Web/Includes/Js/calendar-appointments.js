$(function () {
    // Page load
});

// The scripts that are registered on the UpdatePanel.
function RegisterStartupScript() {
    ScrollToAnchor();
    SetColumnDayWidth();
    UpdateAllAppointments();
}

// Sets 
function SetColumnDayWidth() {
    var days = $(".column-day").length;

    if (days == 1) {
        $(".column-day").addClass("column-day-single");
    }
    else if (days == 7) {
        $(".column-day").addClass("column-day-week");
        $("dd").addClass("hidden");
    }
    else {
        alert(".column-day should be either 1 or 7 and its " + days + ".");
    }
}

// Scrolls to the provided hash
function ScrollToAnchor() {
    var urlHash = window.location.hash;

    if (urlHash) {
        window.location.href = urlHash;
    }
}

// Checks whether two BoundingClientRects are overlapping.
function IsColliding(div1, div2) {
    var x1 = div1.getBoundingClientRect().left;
    var y1 = div1.getBoundingClientRect().top;
    var h1 = div1.getBoundingClientRect().height;
    var w1 = div1.getBoundingClientRect().width;
    var b1 = y1 + h1;
    var r1 = x1 + w1;
    var x2 = div2.getBoundingClientRect().left;
    var y2 = div2.getBoundingClientRect().top;
    var h2 = div2.getBoundingClientRect().height;
    var w2 = div2.getBoundingClientRect().width;
    var b2 = y2 + h2;
    var r2 = x2 + w2;

    if (b1 < y2 || y1 > b2 || r1 < x2 || x1 > r2)
        return false;

    return true;
}

// Updates all the appointmentsif they are overlapping with another appointment.
function UpdateAllAppointments() {
    // All div appointments.
    var appointments = $(".appointment");

    // The amount of collisions object[i] had.
    var collisionCounter = 0;

    // The objects object[i] collided with.
    var collisions = [];

    // Going through all the objects.
    for (var i = 0; i < appointments.length; i++) {
        // Checking all objects with one-another.
        for (var j = 0; j < appointments.length; j++) {
            if (i == j)
                continue;

            if (IsColliding(appointments[i], appointments[j])) {
                collisionCounter++;
                collisions.push(appointments[j]);
            }
        }

        // Object[i] has currently been checked with all other objects and the 
        // amount of collisions are recorded and the collided objects are stored.     

        // Setting the style of object[i].
        appointments[i].style.cssText += "margin-left: 0%; width: " + (100 / (collisionCounter + 1)) + "%;";

        // Looping through the objects object[i] collided with and
        // setting the appropriate widths and margins.
        for (var k = 1; k < collisions.length + 1; k++) {
            var margin = ((100 / (collisionCounter + 1)));
            var width = (100 / (collisionCounter + 1));

            collisions.pop().style.cssText += "margin-left: " + margin + "%; width: " + width + "%;";
        }

        // Resetting the counter and array for the next object.
        collisionCounter = 0;
        collisions = [];
    }
}