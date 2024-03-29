﻿$(function () {
    var isCtrlPressed = false;	

	// Detecting whether the ctrl button was pressed.
	$(document).keydown(function(event) {
		if(event.which == "17") {
		   isCtrlPressed = true;
		}
	});
	
	// Detecting whether the ctrl button was released.
	$(document).keyup(function(event) {
		if(event.which == "17") {
		   isCtrlPressed = false;
		}
	});
	
	// Shows a loading screen.
    function ShowProgress(link) {
        setTimeout(function () {
            var modal = $('<div />');
            modal.addClass("modal");
            $('body').append(modal);
            var loading = $(".loading");
            loading.show();
            var top = Math.max($(window).height() / 2 - loading[0].offsetHeight / 2, 0);
            var left = Math.max($(window).width() / 2 - loading[0].offsetWidth / 2, 0);
            loading.css({ top: top, left: left });

            setTimeout(function () {
                // Prevention for a bug in some versions of IE when double clicking.
                if (link != null) {
                    window.location.replace(link); 
                }
            }, 5000);
        }, 200);
    }
		
	// ASP buttons
    $('form').on("submit", function (e) {
		 if(!Page_IsValid) {
           return;
		}
		
        ShowProgress(null);
    });
	
    // Anchor tags
    $("a").click(function () {
        var href = $(this).attr('href');

        // Ignoring the # hrefs.
        if (href.indexOf("#") != -1)
            return;

        // Ignoring downloads folder clicks.
        if (href.indexOf("downloads") != -1)
            return;

        if (!isCtrlPressed) {
            // Ignoring all the anchors in controls which do postbacks, or update panels, etc.
            if (($(this).hasClass("js-listbox-button")) || (href.indexOf("ExtendedCalendar") != -1) || $(this).hasClass("delete")) {
                return;
            }

            ShowProgress(href);
        }
    });
}); 