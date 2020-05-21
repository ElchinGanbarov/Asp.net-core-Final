$(document).ready(function () {
    var pathname = window.location.pathname;

    $('.nav.navbar-nav').each(function () {
        $(this).find('li').each(function () {
            var current = $(this);
            var menu_link = current.find('a').attr('href');
            if (menu_link === pathname) {
                current.addClass("current-menu-parent");
                current.parents(".menu-item-has-children").addClass("current-menu-parent");
            }
        });
    });
});
