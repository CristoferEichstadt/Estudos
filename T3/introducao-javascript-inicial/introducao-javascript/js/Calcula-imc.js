var pacientes = document.querySelectorAll(".paciente");

for (var i = 0; i < pacientes.length; i++){
    var paciente = pacientes[i];
    
    var tdPeso = paciente.querySelector(".info-peso");
    var peso = tdPeso.textContent;
    
    var tdAltura = paciente.querySelector(".info-altura");
    var altura = tdAltura.textContent;
    
    
    var tdImc = paciente.querySelector(".info-imc");



    var pesoEhValido = validaPeso(peso);
    var AlturaEhValida = validaAltura(altura);


    if (!pesoEhValido) {
        console.log("Peso inválido!");
        pesoEhValido = false;
        tdImc.textContent = "Peso inválido!";
        paciente.classList.add("paciente-invalido");
    }

    if(!AlturaEhValida){
        AlturaEhValida = false;
        tdImc.textContent = "Altura Inválida!";
        paciente.classList.add("paciente-invalido")
    }



    if(pesoEhValido && AlturaEhValida){
        var imc = calculaImc(peso, altura);
        tdImc.textContent = imc;
    }else {
        tdImc.textContent = "Altura e/ou peso inválidos!";
    }
}

function calculaImc(peso, altura){
    var imc = 0;
    imc = peso / (altura * altura);
    
    return imc.toFixed(2);
}

function validaPeso(peso){
    if (peso >= 0 && peso <= 1000) {
        return true;
    } else {
        return false;
    }
}

function validaAltura(altura) {
    if (altura >= 0 && altura <= 3.0) {
        return true;
    } else {
        return false;
    }
}











