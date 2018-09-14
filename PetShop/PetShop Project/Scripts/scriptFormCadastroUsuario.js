
// --> MÁSCARAS <-- //
function mascaraCPF(cpf) {
    cpf = cpf.replace(/\D/g, "")
    cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2")
    cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2")
    cpf = cpf.replace(/(\d{3})(\d{1,2})$/, "$1-$2")
    return cpf
}
function mascaraCNPJ(cnpj) {
    cnpj = cnpj.replace(/\D/g, "")
    cnpj = cnpj.replace(/^(\d{2})(\d)/, "$1.$2")
    cnpj = cnpj.replace(/^(\d{2})\.(\d{3})(\d)/, "$1.$2.$3")
    cnpj = cnpj.replace(/\.(\d{3})(\d)/, ".$1/$2")
    cnpj = cnpj.replace(/(\d{4})(\d)/, "$1-$2")
    return cnpj
}
$(document).ready(function mascaraIE() {
    $("#inscricaoEstadual").bind("keyup blur focus", function (e) {
        e.preventDefault();
        var expre = /[^\d]/g;
        $(this).val($(this).val().replace(expre, ''));
    });
    botaoFisica = document.querySelectorAll(".botao")[0];
    botaoJuridica = document.querySelectorAll(".botao")[1];


    botaoFisica.addEventListener("click", function (event) {
        var corNome = document.querySelector("#textNome");
        var corEmail = document.querySelector("#textEmail");
        var corSenha = document.querySelector("#textSenha");
        var corData = document.querySelector("#textData");

        //nome
        if ($("#nome").val() == "") {
            event.preventDefault();
            corNome.style.color = '#ff0000';
            alert("Preencha o seu nome completo!");
        } else {
            var regexNome = new RegExp("^([A-Z]'?[a-záüóúéíãõàâêô]{2,}\\s(d[oae]\\s)?)([A-Z]'?[a-záàóúéíüãõâêô]{2,}\\s?(d[oae]\\s)?)*([A-Z]'?[a-záüàóúéíãõâêô]{2,})$");
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
    });

    botaoJuridica.addEventListener("click", function (event) {
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
            var regexRSocial = new RegExp("^([\\wáàóúéíüãõâêô]+'?\\s(d[oae]\\s)?)([\\wáàóúéíüãõâêô]+'?\\s?(d[oae]\\s)?)*([\\wáàóúéíüãõâêô]+'?)$");
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
            var regexNomeFantasia = new RegExp("^([\\wáàóúéíüãõâêô]+'?\\s(d[oae]\\s)?)([\\wáàóúéíüãõâêô]+'?\\s?(d[oae]\\s)?)*([\\wáàóúéíüãõâêô]+'?)$");
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

// --> FUNÇÕES <-- //

function VerficaRadioSelecionado() {

    //verifica se o radio de fisica tá "assinalado"
    if ($('#radio-fisica').is(":checked") == true) {
        $('#formulario-fisica').prop('hidden', false);
        $('#nome').focus();
        $('#formulario-juridico').prop('hidden', true);
    }
    else {
        $('#formulario-fisica').prop('hidden', true);
        $('#formulario-juridico').prop('hidden', false);
        $('#razaoSocial').focus();
    }
}

//(cpf)//
function verificaCPF(cpf) {

    if ((cpf = cpf.replace(/[^\d]/g, "")).length != 11)
        return false

    if (cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" || cpf == "44444444444" ||
        cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
        return false;

    var r;
    var s = 0;

    for (i = 1; i <= 9; i++)
        s = s + parseInt(cpf[i - 1]) * (11 - i);

    r = (s * 10) % 11;

    if ((r == 10) || (r == 11))
        r = 0;

    if (r != parseInt(cpf[9]))
        return false;

    s = 0;

    for (i = 1; i <= 10; i++)
        s = s + parseInt(cpf[i - 1]) * (12 - i);

    r = (s * 10) % 11;

    if ((r == 10) || (r == 11))
        r = 0;

    if (r != parseInt(cpf[10]))
        return false;

    return true;
}
function fMasc(objeto, mascara) {
    obj = objeto
    masc = mascara
    setTimeout("fMascEx()", 1)
}
function fMascEx() {
    obj.value = masc(obj.value)
}
function validaInvalidaCpf(el) {
    document.getElementById('cpfResponse').innerHTML = verificaCPF(el.value) ? '<span style="color:green">CPF válido!</span>' : '<span style="color:red">CPF inválido!</span>';
    if (el.value == '') document.getElementById('cpfResponse').innerHTML = '<span> </span>';
}

//(cnpj)//
function verificaCNPJ(cnpj) {

    cnpj = cnpj.replace(/\D/g, "");

    if (cnpj == '') return false;

    if (cnpj.length != 14)
        return false;

    if (cnpj == "00000000000000" || cnpj == "11111111111111" || cnpj == "22222222222222" || cnpj == "33333333333333" ||
        cnpj == "44444444444444" || cnpj == "55555555555555" || cnpj == "66666666666666" || cnpj == "77777777777777" ||
        cnpj == "88888888888888" ||
        cnpj == "99999999999999")
        return false;

    // Valida DVs
    tamanho = cnpj.length - 2
    numeros = cnpj.substring(0, tamanho);
    digitos = cnpj.substring(tamanho);
    soma = 0;
    pos = tamanho - 7;

    for (i = tamanho; i >= 1; i--) {
        soma += numeros.charAt(tamanho - i) * pos--;
        if (pos < 2)
            pos = 9;
    }

    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
    if (resultado != digitos.charAt(0))
        return false;

    tamanho = tamanho + 1;
    numeros = cnpj.substring(0, tamanho);
    soma = 0;
    pos = tamanho - 7;

    for (i = tamanho; i >= 1; i--) {
        soma += numeros.charAt(tamanho - i) * pos--;
        if (pos < 2)
            pos = 9;
    }

    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;

    if (resultado != digitos.charAt(1))
        return false;

    return true;

}
function fMascCnpj(objeto, mascara) {
    obj = objeto
    masc = mascara
    setTimeout("fMascCnpjEx()", 1)
}
function fMascCnpjEx() {
    obj.value = masc(obj.value)
}
function validaInvalidaCnpj(el) {
    document.getElementById('cnpjResponse').innerHTML = verificaCNPJ(el.value) ? '<span style="color:green">CNPJ válido!</span>' : '<span style="color:red">CNPJ inválido!</span>';
    if (el.value == '') document.getElementById('cnpjResponse').innerHTML = '<span></span>';
}

