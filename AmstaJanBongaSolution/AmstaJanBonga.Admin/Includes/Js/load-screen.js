$(function () {
    function ShowProgress() {
        setTimeout(function () {
            var modal = $('<div />');
            modal.addClass("modal");
            $('body').append(modal);
            var loading = $(".loading");
            loading.show();
            var top = Math.max($(window).height() / 2 - loading[0].offsetHeight / 2, 0);
            var left = Math.max($(window).width() / 2 - loading[0].offsetWidth / 2, 0);
            loading.css({ top: top, left: left });
        }, 200);
    }

    // Submits
    $('form').live("submit", function () {
        ShowProgress();
    });

    // Anchor tags
    $("a").click(function () {
        var href = $(this).attr('href');

        if (
            ($(this).hasClass("js-listbox-button")) ||
            (href.indexOf("ExtendedCalendar") != -1)
        ) {
            // Nothing has to be done.
        }
        else {
            ShowProgress();
        }
    });
}); 