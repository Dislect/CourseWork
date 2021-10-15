$(function () {
    $('nav.menu li a').click(function () {
        // удаляем класс .active у всех вкладок
        $('ul.nav.menu li').each(function () {
            $(this).removeClass('active');
        });
        //добавляем для нажатой
        $(this).parent().addClass('active');
    });
});