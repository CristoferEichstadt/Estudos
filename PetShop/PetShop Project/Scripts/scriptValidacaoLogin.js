$(document).ready(function () {
    var botao = document.querySelector("#botao");

    botao.addEventListener("click", function (event) {

        if ($("#email").val() == "") {
            event.preventDefault();
            alert("Preencha o seu e-mail!");
        } else {
            var regexEmail = new RegExp("^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\\-+)|([A-Za-z0-9]+\\.+)|([A-Za-z0-9]+\\++))*[A-Za-z0-9]+@((\\w+\\-+)|(\\w+\\.))*\\w{1,63}\\.[a-zA-Z]{2,6}$");
            if (!regexEmail.test($("#email").val())) {
                event.preventDefault();
                alert("E-mail está no formato incorreto!");
            }
        }

        if ($("#pass").val() == "") {
            event.preventDefault();
            alert("Preencha a sua senha!");
        } else {
            var regexSenha = new RegExp("^[A-Z][a-z]{3}[0-9]{4}$");
            if (!regexSenha.test($("#pass").val())) {
                event.preventDefault();
                alert("Senha está no formato incorreto!");
            }
        }


    })
})