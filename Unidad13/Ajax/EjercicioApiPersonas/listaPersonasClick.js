

function pedirDatos(){
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "https://pablocarboneroasp1.azurewebsites.net/api/personaapi");
    //Definicion estados
    miLlamada.onreadystatechange = function () {
    if (miLlamada.readyState < 4) {
        //aquí se puede poner una imagen de un reloj o un texto “Cargando”
    }
    else 
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            var arrayPersonas = JSON.parse(miLlamada.responseText);
            lasPersonasPremium(arrayPersonas);
        }
    };
    miLlamada.send();
}


function lasPersonas(arrayPersonas){
    let lista = document.getElementById("lista");
    for (let i = 0; i < arrayPersonas.length; i++) {
        let btn = document.createElement("button");
        btn.appendChild(document.createTextNode("Delete"));
        btn.onclick = () => borrarPersona(arrayPersonas[i].id);
        let li = document.createElement("li");
        li.id = arrayPersonas[i].nombre;
        //li.appendChild(document.createTextNode(arrayPersonas[i].nombre));
        li.appendChild(btn);
        lista.appendChild(li);
    }
}

function lasPersonasPremium(arrayPersonas){
    document.getElementById("lista").innerHTML = arrayPersonas.map((persona) => 
        `<li id=${persona.id}>${persona.nombre}</li>
        <button onclick="borrarPersona(${persona.id})">Delete</button>`
    ).join('');
}

function borrarPersona(id){
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("DELETE", "https://pablocarboneroasp1.azurewebsites.net/api/personaapi/" + id);

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            //aquí se puede poner una imagen de un reloj o un texto “Cargando”
        }
        else if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                pedirDatos();
            }
        };
    miLlamada.send();
};


function vaciarLista(){
    let lista = document.getElementById("lista");
    while (lista.firstChild) {
        lista.removeChild(lista.firstChild);
    }
   pedirDatos();
}
