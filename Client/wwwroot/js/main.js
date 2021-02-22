var MobileNavBtn = document.getElementById('burgerBtn');
var mainContend = document.getElementById('mainContend');

MobileNavBtn.addEventListener('click', function() {
    mainContend.classList.toggle('mobileNav');
}, false);
