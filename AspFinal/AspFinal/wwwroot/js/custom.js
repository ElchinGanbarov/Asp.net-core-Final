// Ajax element Remove//
$(document).ready(function () {
    $(".deleteitem").click(function (e) {
        let elem = $(this).parents(".item");
        let href = $(this).attr("href");
        $.confirm({
            title: 'Məlumat silinməsi',
            content: 'Məlumat silinsin mi?',
            buttons: {
                'Bəli': {
                    btnClass: "btn-danger",
                    action: function () {
                        $.ajax({
                         url: href,
                         type: "get",
                         dataType:"html",
                            success: function (response) {
                         elem.remove();
                            }
                         });
                    }
                },
                'Xeyir': function () {
                }
            }
        });
             e.preventDefault();
    });
});
//$(document).on("click", ".deleteitem", function (ev) {
//    let elem = $(this).parents(".item");
//    $.ajax({
//        url: $(this).attr("href"),
//        type: "get",
//        success: function (response) {
//            elem.remove();
//            console.log("test");
//        }
//    });
//    ev.preventDefault();
//});

   

