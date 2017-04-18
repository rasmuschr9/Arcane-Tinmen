$(document).ready(function () {
    //Body offset
    function adjust_body_offset() {
        $('body').css('padding-top', $('.navbar-default').outerHeight(true) + 'px');
    }
    $(window).resize(adjust_body_offset);
    $(document).ready(adjust_body_offset);

    //TABLE SPECIFICATIONS
    $('.specs tr:nth-child(1) td').before('<td>Height</td>');
    $('.specs tr:nth-child(2) td').before('<td>Width</td>');
    $('.specs tr:nth-child(3) td').before('<td>Depth</td>');

    //TO TOP BUTTON
    $(window).scroll(function () {
        if ($(this).scrollTop() > 50) {
            $('#back-to-top').fadeIn();
        } else {
            $('#back-to-top').fadeOut();
        }
    });
    // scroll body to 0px on click
    $('#back-to-top').click(function () {
        $('#back-to-top').tooltip('hide');
        $('body,html').animate({
            scrollTop: 0
        }, 800);
        return false;
    });
    $('#back-to-top').tooltip('show');

    //MAKE LINKS TO DROPDOWN
    $('.dropdown-toggle').dropdown()

    //NEWSLETTER
    $('.newsletter-form').submit(function (e) {
        var form = this;
        e.preventDefault();
        setTimeout(function () {
            form.submit();
        }, 5000); // in milliseconds
        $("<div class='thank-you'><h1>Thank you for subscribbing to our newsletter</h1><p>Page will reload in 5 seconds</p></div>").appendTo("body");
    });
    //LIGHTBOX
    var $lightbox = $('#lightbox');

    $('[data-target="#lightbox"]').on('click', function (event) {
        var $img = $(this).find('img'),
            src = $img.attr('src'),
            alt = $img.attr('alt'),
            css = {
                'maxWidth': $(window).width() - 100,
                'maxHeight': $(window).height() - 100
            };

        $lightbox.find('.close').addClass('hidden');
        $lightbox.find('img').attr('src', src);
        $lightbox.find('img').attr('alt', alt);
        $lightbox.find('img').css(css);
    });

    $lightbox.on('shown.bs.modal', function (e) {
        var $img = $lightbox.find('img');

        $lightbox.find('.modal-dialog').css({ 'width': $img.width() });
        $lightbox.find('.close').removeClass('hidden');
    });
});