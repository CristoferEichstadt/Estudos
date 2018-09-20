var campo = $(".campo-digitacao");
campo.on("input", function () {
    var conteudo = campo.val();

    var qtdPalavas = conteudo.split(/\S+/).length;
    $("#contador-palavras").text(qtdPalavas);

    var qtdCaracteres = conteudo.length;
    $("#contador-caracteres").text(qtdCaracteres);
});


var tempoRestante = $("#tempo-digitacao").text();
campo.one("focus", function () {

    var idCronometro = setInterval(function () {
        tempoRestante--;
        $("#tempo-digitacao").text(tempoRestante);
        if (tempoRestante < 1) {
            campo.attr("disabled", true);
            clearInterval(idCronometro);
        }
    }, 1000);

});
