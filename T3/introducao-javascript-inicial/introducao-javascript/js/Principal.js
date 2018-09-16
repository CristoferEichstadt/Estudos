var pacientes = document.querySelectorAll(".paciente");

for(var i = 0; i < pacientes.length; i++){
    var paciente = pacientes[i];
    
    var tdPeso = paciente.querySelector(".info-peso");
    var peso = tdPeso.textContent;
    
    var tdAltura = paciente.querySelector(".info-altura");
    var altura = tdAltura.textContent;
    
    
    var tdImc = paciente.querySelector(".info-imc");



    var pesoEhValido = true;
    var AlturaEhValida = true;

    if(peso <= 0 || peso >= 1000){
        pesoEhValido = false;
        tdImc.textContent = "Peso Inválido!";
        paciente.classList.add("paciente-invalido")
    }

    if(altura <= 0 || altura >= 3.00){
        AlturaEhValida = false;
        tdImc.textContent = "Altura Inválida!";
        paciente.classList.add("paciente-invalido")
    }



    if(pesoEhValido && AlturaEhValida){
        var imc = peso / (altura * altura);
        tdImc.textContent = imc.toFixed(2);
    }else {
        tdImc.textContent = "Altura e/ou peso inválidos!";
    }

}