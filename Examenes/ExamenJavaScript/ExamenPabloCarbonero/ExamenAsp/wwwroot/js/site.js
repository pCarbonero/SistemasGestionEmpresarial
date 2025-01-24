// lista de departamentos
let listaDepartamentos

class Departamento {
    constructor(id, nombre) {
        this.id = id;
        this.nombre = nombre;
    }
}

/**
 * Al cargar la pagina se llama a la funcion de cargarDepartamentos
 */
window.onload = function () {
    cargarDepartamentos();
};


/**
 * Metodo que se encarga de realizar una llamada a la api para obtener todos los departamentos
 */
function cargarDepartamentos() {
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "http://localhost:5224/api/departamento");
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            console.log("Cargando...")
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                listaDepartamentos = JSON.parse(miLlamada.responseText);

                let selectDepartamentos = document.getElementById("selectDepartamentos");

                listaDepartamentos.forEach(departamento => {
                    const option = document.createElement("option");
                    option.value = departamento.id; 
                    option.textContent = departamento.nombre; 
                    selectDepartamentos.appendChild(option);
                    
                });
            }
    };
    miLlamada.send();
}

/**
 * Metodo que se encarga de realizar una llamada a la api para obtener la lista de personas
 */
function cargarListaPersonas() {
    let selectDepartamentos = document.getElementById("selectDepartamentos")
    let dept = new Departamento(selectDepartamentos.value, selectDepartamentos.textContent.trim())
    let deptSeleccionado = JSON.stringify(dept)

    let miLlamada = new XMLHttpRequest();
    miLlamada.open("POST", "http://localhost:5224/api/persona");

    miLlamada.setRequestHeader("Content-Type", "application/json");

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            console.log("Cargando...")
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                let listaPersonas = JSON.parse(miLlamada.responseText);
                tablaPersonas(listaPersonas)
            }
    };
    miLlamada.send(deptSeleccionado);
}


/**
 * Metodo que escribe en la lista las persoans de ese departamento
 * @param {any} listaPersonas
 */
function tablaPersonas(listaPersonas) {
    document.getElementById("tabla").innerHTML =
        `<tr>
            <th>Nombre</th>
            <th>Apellidos</th>
        </tr>`
        +
        listaPersonas.map((persona) =>
            `<tr onClick="obtenerPersona(${persona.id})">
                <td>${persona.nombre}</th>
                <td>${persona.apellidos}</th>
            </tr>`
        ).join('');
}

/**
 * Funcion que hace la llamada a la api para obtener una persona con un id para los detalles
 * @param {any} id
 */
function obtenerPersona(id) {
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", `http://localhost:5224/api/persona/${id}`);

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            console.log("Cargando...")
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                let persona = JSON.parse(miLlamada.responseText);
                detallesPersona(persona)
            }
    };
    miLlamada.send();
}

/**
 * Funcion que se encarga de escribir los detalles en el div correspondiente
 * @param {any} persona
 */
function detallesPersona(persona) {
    let fechaCorrecta = new Date(persona.fechaNacimiento).toISOString().split('T')[0]

    document.getElementById("detalles").innerHTML =
        `<br><br><label>Nombre: ${persona.nombre}</label> <br>
        <label>Apellidos: ${persona.apellidos}</label><br>
        <label>Telefono: ${persona.telefono}</label><br>
        <label>Fecha de nacimiento: ${fechaCorrecta}</label><br>
        <label>Departamento: ${persona.nombreDepartamento}</label>`;
}
