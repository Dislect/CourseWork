$("#form1").submit(function () {
    var jqxhr = $.post('/Authors/Create', $('#form1').serialize())
        .success(function () {
            alert('super');
        })
        .error(function () {
            alert('superneoh');
        });
    return false;
});

$("#zxc").click(function () {
    var name1 = document.getElementById('name').value;
    var surname1 = document.getElementById('surname').value;
    var patronymic1 = document.getElementById('patronymic').value;
    console.log(name1 + surname1 + patronymic1);
    var jqxhr = $.post('/Authors/Create',
            {
                name: name1,
                surname: surname1,
                patronymic: patronymic1,
                id: 100
            })
        .done(function () {
            var id = $('tr:last').children().first().text();
            $('.Table tr:last').after('<tr>' +
                '<td>' + (parseInt(id) + parseInt(1)) + '</td>' +
                '<td>' + name1 + '</td>' +
                '<td>' + surname1 + '</td>' +
                '<td>' + patronymic1 + '</td>' +
                '<td> <a href="/Authors/Edit/20">Изменить</a> <br> <a href="/Authors/Delete/20">Удалить</a> </td>' +
                '</tr>');
            console.log('ura - '+ id);
        })
        .fail(function () {
            console.log('Neura');
        });
    return false;
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


