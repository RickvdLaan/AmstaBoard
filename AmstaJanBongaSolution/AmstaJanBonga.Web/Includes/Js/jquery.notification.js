(function ($) {
    var animationSpeed = 500;

    var methods = {
        renderNotification: function (message) {
            var notificationContainer, notificationInner;

            var localSettings = {};
            $.extend(localSettings, message);

            notificationContainer = $('<div></div>').addClass('notification-position').appendTo('#content');
            notificationInner = $('<div></div>').hide().addClass('notification-container').appendTo(notificationContainer).html($('<p>').append(localSettings.message)).animate({ opacity: 'show' }, animationSpeed);

            setTimeout(function () {
                $().renderMessage('removeNotification', notificationInner, localSettings);
            }, localSettings.message.length * 75);
        },

        showNotification: function (message) {
            return $().renderMessage('renderNotification', { message: message });
        },

        removeNotification: function (obj) {
            obj.animate({ opacity: 'hide' }, animationSpeed, function () {
                obj.parent().remove();
            });
        }
    };

    $.fn.renderMessage = function (method) {
        if (methods[method]) {
            return methods[method].apply(this, Array.prototype.slice.call(arguments, 1));
        }
    };
})(jQuery);