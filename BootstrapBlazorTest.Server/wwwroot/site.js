(function ($) {
    $.extend({
        table_test: function (el, obj, method) {
            var $el = $(el);
            $el.on('click', 'tbody tr', function () {
                $el.find('.active').removeClass('active');
                var index = $(this).addClass('active').data('index');

                obj.invokeMethodAsync(method, index);
            });
        }
    });
})(jQuery);