$(document).ready(function () {



    //    $('.borderImage').click(function () {
    //        if ($(this).hasClass('img-big')) {
    //            $(this).removeClass('img-big');
    //        } else {
    //            $(this).addClass('img-big');
    //        }

    //    })

    //})

    //$('img').dblclick(function () {

    //    $(this).css('width', '200px');
    //    $(this).css('height', '300px');
    //});

    $('.minimized').click(function (event) {
        var i_path = $(this).attr('src');
        $('body').append('<div id="overlay"></div><div id="magnify"><img src="' +
            i_path + '"><div id="close-popup"><i></i></div></div>');
        $('#magnify').css({
            left: ($(document).width() - $('#magnify').outerWidth()) / 2,
            // top: ($(document).height() - $('#magnify').outerHeight())/2 upd: 24.10.2016
            top: ($(window).height() - $('#magnify').outerHeight()) / 2
        });
        $('#overlay, #magnify').fadeIn('fast');
    });

    $('body').on('click', '#close-popup, #overlay', function (event) {
        event.preventDefault();

        $('#overlay, #magnify').fadeOut('fast', function () {
            $('#close-popup, #magnify, #overlay').remove();
        });
    })
});



//$(document).ready(function () 
//     {
//    $('#submenu').hide();
//    $('#navbar').hover(
//    function () {
//        $('#submenu').show();
//    }
//, function () {
//    $('#submenu').hide();
//}
//);
//    });   //  конец события  double click 


//$(document).ready(function () {
//    $('html').dblclick(function () {

//    });   //  конец события  double click 
//});

//$(document).ready(function () {
//    $('a').mouseover(function(){
//        var message = "<p>Вы навели указатель мыши на ссылку</p>";
//        $('#categories').append(message);
//    });
//});

//$(document).ready(function () {
//    $('a').click(function () {
//        var message = "<p> Это новая ссылка</p>";
//        $('#categories').append(message);
//    })
//})

//$(document).ready(function () {
//    $('#firstButton').click(function () {
//        $(this).val('Второй');
//    })
//})

