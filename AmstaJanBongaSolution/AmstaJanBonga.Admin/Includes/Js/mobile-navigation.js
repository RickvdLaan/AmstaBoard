jQuery(document).ready(function($) {
    $("#mobile-menu").on("click", function () {
        $("#nav").slideToggle();
        $(this).toggleClass("active");
    });
});