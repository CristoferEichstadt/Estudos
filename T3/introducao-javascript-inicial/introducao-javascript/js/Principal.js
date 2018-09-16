var paciente = document.querySelector("#primeiro-paciente");
var tdPeso = document.querySelector(".info-peso");
var tdAltura = document.querySelector(".info-altura");

var altura = tdAltura.textContent;
var peso = tdPeso.textContent;

var imc = peso / (altura * altura);

console.log(imc);