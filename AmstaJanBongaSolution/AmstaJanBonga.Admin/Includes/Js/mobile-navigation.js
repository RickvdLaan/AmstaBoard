jQuery(document).ready(function($) {
    $("#mobile-menu").on("click", function () {
        $("#NavigationControl_nav").slideToggle();
        $(this).toggleClass("active");
    });
});