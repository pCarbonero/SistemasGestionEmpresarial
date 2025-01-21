
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
    const persona = {
        nombre: nombre,
        apellidos: apellidos,
        dept: dept,
    };

    let miLlamada = new XMLHttpRequest();
    miLlamada.open("POST", "http://localhost:5038/api/persona");

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
    miLlamada.send();
}

function personasTabla(arrayPersonas)
{
    document.getElementById("lista").innerHTML = arrayPersonas.map((persona) =>
        `<li id=${persona.id}>${persona.nombre}</li>`
    ).join('');
}