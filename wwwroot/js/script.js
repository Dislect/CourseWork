$('#form1').submit(function (event) {
    event.preventDefault();
    $.ajax({
        url: '/Authors/Create',
        data: $("#form1").serialize(),
        type: 'POST',
        success: function (id) {
            $('.Table tr:last').after(
                '<tr>' +
                '<td>' + id + '</td>' +
                '<td>' + document.getElementById('name').value + '</td>' +
                '<td>' + document.getElementById('surname').value + '</td>' +
                '<td>' + document.getElementById('patronymic').value + '</td>' +
                '<td> <a href="/Authors/Edit/' + id + '">Изменить</a> <br> <a href="/Authors/Delete/' + id + '">Удалить</a> </td>' +
                '</tr>');
        }
    });
});

$(function () {
    try {
        var el = $('.menu a');
        var url = document.location.href;
        for (var i = 0; i < el.length; i++) {
            if (url == el[i].href && !url.includes("/Home/Home")) {
                el[i].className += 'active';
            };
        };
    } catch (e) { }
});

$('#nech').click(function () {
    var arr = $('tbody tr');
    for (var i = 0; i < arr.length; i++) {
        var id = $(arr[i]).children().first().html();
        if (id % 2 != 0) {
            $(arr[i]).css('background-color', 'silver');
        }
    }
});

$('tbody tr').mouseenter(function () {
    var bgLast = $(this).css('background-color');
    $(this).css('background-color', 'aquamarine');
    $(this).mouseleave(function () {
        $(this).css('background-color', bgLast);
    });
});