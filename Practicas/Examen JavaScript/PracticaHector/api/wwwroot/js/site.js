// PARA IR A ITRA OAGINA window.location.href='pagina_destino.html'

window.onload = function () {
    obtenerBandos();
};

class PersonajeEdadBando {
    constructor(nombreBando, edad, id, nombre, fechaNacimiento, idBando){
        this.nombreBando = nombreBando;
        this.edad = edad;
        this.id = id;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.idBando = idBando;
    }
}

class Personaje {
    constructor(nombre, fechaNacimiento, idBando) {
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.idBando = idBando;
    }
}

let listaBandos;

function obtenerBandos() {
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "http://localhost:5082/api/bando");
    //Definicion estados
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //aquí se puede poner una imagen de un reloj o un texto “Cargando”
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                listaBandos = JSON.parse(miLlamada.responseText);

                let bandoSelect = document.getElementById("bandoSelect");

                listaBandos.forEach(bando => {
                    const option = document.createElement("option");
                    option.value = bando.id; // El valor será el ID del bando
                    option.textContent = bando.nombre; // Lo visible será el nombre
                    bandoSelect.appendChild(option);
                });
            }
    };
    miLlamada.send();
}


function cargarPersonajes() {
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "http://localhost:5082/api/personaje");
    let listaPersonajes;
    //Definicion estados
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //aquí se puede poner una imagen de un reloj o un texto “Cargando”
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                listaPersonajes = JSON.parse(miLlamada.responseText);
                cargarPersonajesTabla(listaPersonajes);
            }
    };
    miLlamada.send();
}

function cargarPersonajesTabla(listaPersonajes) {
    document.getElementById("tabla").innerHTML =
        `<tr>
            <th>Nombre</th>
        </tr>`
        +
        listaPersonajes.map((persona) =>
        `<tr>
            <th>${persona.nombre}</th>
            <th><button onclick="deletePersonaje(${persona.id})">Borrar</button> <button onclick="obtenerPersonaje(${persona.id})">Detalles</button></th>
        </tr>`
    ).join('');
}


function obtenerPersonaje(id) {
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", `http://localhost:5082/api/personaje/${id}`);
    let personaje;
    //Definicion estados
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //aquí se puede poner una imagen de un reloj o un texto “Cargando”
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                personaje = JSON.parse(miLlamada.responseText);
                detalles(personaje);
            }
    };
    miLlamada.send();
}

function detalles(personaje) {
    document.getElementById("detalles").innerHTML = `
        <h3>Detalles del Personaje</h3>
        <p><strong>Nombre:</strong> ${personaje.nombre}</p>
        <p><strong>Edad:</strong> ${personaje.edad}</p>
        <p><strong>Bando:</strong> ${personaje.nombreBando}</p>
    `;
}



function crearPersonaje() {
    let nombre = document.getElementById("nombre").value;
    let fechaNacimiento = document.getElementById("date").value;
    let idBando = document.getElementById("bandoSelect").value;

    let sePudo;


    let miLlamada = new XMLHttpRequest();
    miLlamada.open("POST", "http://localhost:5082/api/personaje");

    let p = new Personaje (nombre, fechaNacimiento, idBando)

    // Configurar las cabeceras para JSON
    miLlamada.setRequestHeader("Content-Type", "application/json");

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //cargando...
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                document.getElementById("add").style.visibility = "hidden"
                //text.value = "";
            }
            else {
                document.getElementById("error").value = "Error"
            }
    };
    miLlamada.send(JSON.stringify(p));
}

function cargarOpciones() {
    let div = document.getElementById("add").style.visibility = "visible";
}


function deletePersonaje(id) {
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("DELETE", `http://localhost:5082/api/personaje/${id}`);
    let personaje;
    //Definicion estados
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //aquí se puede poner una imagen de un reloj o un texto “Cargando”
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                cargarPersonajes();
            }
    };
    miLlamada.send();
}

