class Persona {
    constructor (nombres, apellidos) {
        this.nombres = nombres
        this.apellidos = apellidos
    }
}


function saludar() {
    let persona = new Persona(document.getElementById("nombreSaludar").value, document.getElementById("apellidosSaludar").value)
    alert(`Hola ${persona.nombres} ${persona.apellidos}`)
}


//Inicializar los eventos
window.onload = inicializaEventos;

function inicializaEventos() {
    //document.getElementById("btnSaludar").onclick = saludar;
    document.getElementById("btnSaludar").addEventListener("click", saludar,false);
}