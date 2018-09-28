$(document).ready(function () {
    botaoFisica = document.querySelectorAll(".botao")[0];
    botaoJuridica = document.querySelectorAll(".botao")[1];


    botaoFisica.addEventListener("click", function (event) {
        var corNome = document.querySelector("#textNome");
        var corEmail = document.querySelector("#textEmail");
        var corSenha = document.querySelector("#textSenha");
        var corData = document.querySelector("#textData");
        var corCpf = document.querySelector("#textCpf");

        //nome
        if ($("#nome").val() == "") {
            event.preventDefault();
            corNome.style.color = '#ff0000';
            alert("Preencha o seu nome completo!");
        } else {
            var regexNome = new RegExp("^([A-Z]'?[a-záüóúéíãõàâêôç]{2,}\\s(d[oae]\\s)?)([A-Z]'?[a-záàóúéíüãõâêôç]{2,}\\s?(d[oae]\\s)?)*([A-Z]'?[a-záüàóúéíãõâêôç]{2,})$");
            if (!regexNome.test($("#nome").val())) {
                event.preventDefault();
                corNome.style.color = '#ff0000';
                alert("Nome está incorreto!");
                alert("Lembre-se, nome deve iniciar com letra maiúscula e deve ser completo!");
            } else {
                corNome.style.color = '#000000';
            }
        }
        //email
        if ($("#emailFisica").val() == "") {
            event.preventDefault();
            corEmail.style.color = '#ff0000';
            alert("Preencha o seu e-mail!");
        } else {
            var regexEmail = new RegExp("^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\\-+)|([A-Za-z0-9]+\\.+)|([A-Za-z0-9]+\\++))*[A-Za-z0-9]+@((\\w+\\-+)|(\\w+\\.))*\\w{1,63}\\.[a-zA-Z]{2,6}$");
            if (!regexEmail.test($("#emailFisica").val())) {
                event.preventDefault();
                corEmail.style.color = '#ff0000';
                alert("E-mail está incorreto!");
            } else {
                corEmail.style.color = '#000000';
            }
        }

        //senha
        if ($("#senhaFisica").val() == "") {
            event.preventDefault();
            corSenha.style.color = '#ff0000';
            alert("Preencha a sua senha!");
        } else {
            var regexSenha = new RegExp("^[A-Z][a-z]{3}[0-9]{4}$");
            if (!regexSenha.test($("#senhaFisica").val())) {
                console.log(regexSenha.test($("#senhaFisica").val()));
                event.preventDefault();
                corSenha.style.color = '#ff0000';
                alert("Senha está incorreta!");
                alert('Lembre-se, a senha deve seguir o formato "Aaaa0000"!');
            } else {
                corSenha.style.color = '#000000';
            }
        }

        //data nascimento
        if ($("#dataNascimento").val() == "") {
            event.preventDefault();
            corData.style.color = '#ff0000';
            alert("Preencha a data de nascimento!");
        } else {
            corData.style.color = '#000000';
        }

        //cpf
        if ($("#cpf").val() == "") {
            event.preventDefault();
            corCpf.style.color = '#ff0000';
            alert("Preencha seu cpf!");
        } else {
            corCpf.style.color = '#000000';
        }
    });

    botaoJuridica.addEventListener("click", function (event) {
        var corRSocial = document.querySelector("#textRazaoSocial");
        var corNomeFant = document.querySelector("#textNomeFant");
        var corIE = document.querySelector("#textIE");
        var corEmailJuridica = document.querySelector("#textEmailJuridica");
        var corSenhaJuridica = document.querySelector("#textSenhaJuridica");
        var corCnpj = document.querySelector("#textCnpj")


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

        //cnpj
        if ($("#cnpj").val() == "") {
            event.preventDefault();
            corCnpj.style.color = '#ff0000';
            alert("Preencha o cnpj!");
        } else {
            corCnpj.style.color = '#000000';
        }

    });
});

