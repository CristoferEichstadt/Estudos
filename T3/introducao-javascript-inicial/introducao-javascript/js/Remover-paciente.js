var paciente = document.querySelectorAll(".pacientes");

pacientes.forEach(function(paciente){
    paciente.addEventListener("dblclick", function(){
       console.log("clickado");
        this.remove();
    });
});