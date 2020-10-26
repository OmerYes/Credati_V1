jQuery(function ($) {
    $("#contactForm").validate({
        rules: {
            Email: {
                required: true,
                email: true,
            },
            Name: {
                required: true,
            },

            Body: {
                required: true,
                minlength:5,
            }
        },

        messages: {
            Email: {
                required: "**Lütfen email adresinizi giriniz",
                email: "**Lütfen geçerli bir mail adresi giriniz"
            },
            Name: "**Lütfen adınızı giriniz",
            Body: {
                required: "**Lütfen mesajınızı yazınız",
                minlength:"**Lütfen en az beş karakter giriniz"
            }
        }
    })
})