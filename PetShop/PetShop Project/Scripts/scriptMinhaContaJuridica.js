$(document).ready(function () {

    botaoJuridico = document.querySelector(".salvaDadosJuridicos");

    botaoJuridico.addEventListener("click", function (event) {
        var corRSocial = document.querySelector("#textRazaoSocial");
        var corNomeFant = document.querySelector("#textNomeFant");
        var corIE = document.querySelector("#textIE");
        var corEmailJuridica = document.querySelector("#textEmailJuridica");
        var corSenhaJuridica = document.querySelector("#textSenhaJuridica");


        //razao social
        if ($("#razaoSocial").val() == "") {
            event.preventDefault();
            corRSocial.style.color = '#ff0000';
            alert("Preencha a razão social completo!");
        } else {
            var regexRSocial = new RegExp("^([\\wáàóúéíüãõâêôç]+'?\\s(d[oae]\\s)?)([\\wáàóúéíüãõâêôç]+'?\\s?(d[oae]\\s)?)*([\\wáàóúéíüãõâêôç]+'?)$");
            if (!regexRSocial.test($("#razaoSocial").val())) {
                event.preventDefault();
                corRSocial.style.color = '#ff0000';
                alert("Razão Social está incorreta!");
            } else {
                corRSocial.style.color = '#000000';
            }
        }

        //nome fantasia
        if ($("#nomeFantasia").val() == "") {
            event.preventDefault();
            corNomeFant.style.color = '#ff0000';
            alert("Preencha o nome fantasia completo!");
        } else {
            var regexNomeFantasia = new RegExp("^([\\wáàóúéíüãõâêôç]+'?\\s(d[oae]\\s)?)([\\wáàóúéíüãõâêôç]+'?\\s?(d[oae]\\s)?)*([\\wáàóúéíüãõâêôç]+'?)$");
            if (!regexNomeFantasia.test($("#nomeFantasia").val())) {
                event.preventDefault();
                corNomeFant.style.color = '#ff0000';
                alert("Nome Fantasia está incorreto!");
            } else {
                corNomeFant.style.color = '#000000';
            }
        }

        //IE
        if ($("#inscricaoEstadual").val() == "") {
            event.preventDefault();
            corIE.style.color = '#ff0000';
            alert("Preencha a inscrição estadual completa!");
        } else {
            var regexIe = new RegExp("^[0-9]{4,11}");
            if (!regexIe.test($("#inscricaoEstadual").val())) {
                event.preventDefault();
                corIE.style.color = '#ff0000';
                alert("Inscrição Estadual incorreta!");
            } else {
                corIE.style.color = '#000000';
            }
        }

        //email
        if ($("#emailJuridica").val() == "") {
            event.preventDefault();
            corEmailJuridica.style.color = '#ff0000';
            alert("Preencha o seu e-mail!");
        } else {
            var regexEmailJuridica = new RegExp("^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\\-+)|([A-Za-z0-9]+\\.+)|([A-Za-z0-9]+\\++))*[A-Za-z0-9]+@((\\w+\\-+)|(\\w+\\.))*\\w{1,63}\\.[a-zA-Z]{2,6}$");
            if (!regexEmailJuridica.test($("#emailJuridica").val())) {
                event.preventDefault();
                corEmailJuridica.style.color = '#ff0000';
                alert("E-mail está incorreto!");
            } else {
                corEmailJuridica.style.color = '#000000';
            }
        }

        //senha
        if ($("#senhaJuridica").val() == "") {
            event.preventDefault();
            corSenhaJuridica.style.color = '#ff0000';
            alert("Preencha a sua senha!");
        } else {
            var regexSenhaJuridica = new RegExp("^[A-Z][a-z]{3}[0-9]{4}$");
            if (!regexSenhaJuridica.test($("#senhaJuridica").val())) {
                event.preventDefault();
                corSenhaJuridica.style.color = '#ff0000';
                alert("Senha está incorreta!");
                alert('Lembre-se, a senha deve seguir o formato "Aaaa0000"!');
            } else {
                corSenhaJuridica.style.color = '#000000';
            }
        }

    });
});