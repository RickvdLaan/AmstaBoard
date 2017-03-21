$(function () {
    UpdateAllAppointments();
    //ResolveAppointments();
    SetColumnDayWidth();
});

function SetColumnDayWidth() {
    var days = $(".column-day").length;

    if (days == 1) {
        $(".column-day").addClass("column-day-single");
    }
    else if (days == 7) {
        $(".column-day").addClass("column-day-week");
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

// Counts the amount of collisions for a specific appointment.
function TotalCollisions(appointment)
{
    var appointments = $(".appointment");
    var overlaps = 0;

    for (var i = 0; i < appointments.length; i++) {
        if (IsColliding(appointment, appointments[i])) {
            overlaps++;
        }
    }

    // correction for checking itself.
    return overlaps - 1;
}

function ResolveAppointments() {
    var appointments = $(".appointment");

    var collisions = 0;

    for (var i = 0; i < appointments.length; i++) {
        for (var j = 0; j < appointments.length; j++) {
            if (i == j) {
                continue;
            }

            if (IsColliding(appointments[i], appointments[j])) {
                collisions++;
            }
        }

        // Collisions: 1 - 2 - 1 - 2 - 2 - 2
        // Expected widths:
        // 50
        // 33.33 (but should be 50 in this case)
        // 50
        // 33.33
        // 33.33
        // 33.33

        var width = 100 / (collisions + 1);
                
        // Expected margins:
        // 0
        // 50
        // 0
        // 0
        // 33.33
        // 66.66

        collisions = 0;
    }
}

// Updates all the appointmentsif they are overlapping with another appointment.
function UpdateAllAppointments() {
    var appointments = $(".appointment");

    for (var i = 0; i < appointments.length; i++) {
        for (var j = i + 1; j < appointments.length; j++) {
            if (IsColliding(appointments[i], appointments[j])) {
                //appointments[i].classList.add("appointment-position");
                //appointments[j].classList.add("appointment-position");

                appointments[i].style.cssText += "margin-left: 50%; width: 50%;";
                appointments[j].style.cssText += "margin-left: 0%; width: 50%;";

                if (IsColliding(appointments[j], appointments[j + 1])) {
                    appointments[i].style.cssText += "margin-left: 0%; width: 50%;";
                    appointments[j].style.cssText += "margin-left: 50%; width: 50%;";
                }
            }
        }
    }
}