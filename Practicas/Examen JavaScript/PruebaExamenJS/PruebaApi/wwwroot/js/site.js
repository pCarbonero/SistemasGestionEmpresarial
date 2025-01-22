window.onload = function () {
    cargarDepartamentos()
};

let departamentos = [];


function cargarDepartamentos() {
    let text
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "http://localhost:5038/api/departamento");

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //text = getElementById("Cargando")
            //text.value = "Cargando..."
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                var arrayDepartamentos = JSON.parse(miLlamada.responseText);
                departamentos = arrayDepartamentos;
                //text.value = "";
            }
    };
    miLlamada.send();
}

function cargarPersonas()
{       
    let text
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "http://localhost:5038/api/persona");

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //text = getElementById("Cargando")
            //text.value = "Cargando..."
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                var arrayPersonas = JSON.parse(miLlamada.responseText);
                personasTabla(arrayPersonas);
                //text.value = "";
            }
    };
    miLlamada.send();
}

function addPersona()
{
    let nombre = document.getElementById("nombre").value;
    let apellidos = document.getElementById("Apellidos").value;
    let dept = document.getElementById("Dept").value;   

    // Crear el objeto persona
    const clsPersona = {
        nombre: nombre,
        apellidos: apellidos,
        dept: parseInt(dept)
    };

    // tengo que serializar antes el objeto? tiene que llamarse igual que la entidad clsPersona?

    let miLlamada = new XMLHttpRequest();
    miLlamada.open("POST", "http://localhost:5038/api/persona", true);

    // Configurar las cabeceras para JSON
    miLlamada.setRequestHeader("Content-Type", "application/json");

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //text = getElementById("Cargando")
            //text.value = "Cargando..."
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                cargarPersonas()
                //text.value = "";
            }
    };
    miLlamada.send(JSON.stringify(clsPersona));
}

function personasTabla(arrayPersonas)
{
    let nombreDept
    document.getElementById("tabla").innerHTML = arrayPersonas.map((persona) => {
        for (let d of departamentos) {

            if (parseInt(d.id) == persona.idDept)
                nombreDept = d.nombre  
        }
        return `
        <tr>
            <td>${persona.id}</td>
            <td>${persona.nombre}</td>
            <td>${persona.apellidos}</td>
            <td>${nombreDept}</td>
        </tr>`;
    }
    ).join('')
}

function obtenerNombreDept(idDept) {
    let nombre
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "http://localhost:5038/api/departamento");
    miLlamada.setRequestHeader("Content-Type", "application/json");

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //text = getElementById("Cargando")
            //text.value = "Cargando..."
        }
        else
            if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                nombre = JSON.parse(miLlamada.responseText);
            }
    };
    miLlamada.send(idDept);
    return nombre
}

                /*
                <tr>
            <th>Id</th>
            <th>Nombre</th>
            <th>Apellidos</th>
            <th>Departamento</th>
        </tr>
                */