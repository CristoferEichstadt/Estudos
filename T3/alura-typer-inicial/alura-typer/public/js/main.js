var frase = $(".frase").text();
var numeroPalavras = frase.split(" ").length;

var tamanhoFrase = $("#tamanho-frase").text(numeroPalavras);


var campo = $(".campo-digitacao");
campo.on("input", function(){
    var conteudo = campo.val();
    
    var qtdPalavas = conteudo.split(/\S+/).length;
    $("#contador-palavras").text(qtdPalavas);
    
    var qtdCaracteres = conteudo.length;
    $("#contador-caracteres").text(qtdCaracteres);
});