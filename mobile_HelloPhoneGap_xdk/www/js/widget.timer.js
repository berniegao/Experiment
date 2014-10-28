(function ($) {

    $.fn.timer = function (maxValue) {
        $(this).each(function () {
            this.max = maxValue;
            this.value = 0;
            var progress = this;
            var timer = window.setInterval(function (obj) {
                progress.value = progress.value + 1;
            }, 1000);
        })
    };
})(af);
