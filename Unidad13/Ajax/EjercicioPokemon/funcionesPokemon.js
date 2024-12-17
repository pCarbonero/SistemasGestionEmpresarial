function pedirDatos(){
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "https://pokeapi.co/api/v2/pokemon?limit=100&offset=151");
    //Definicion estados
    miLlamada.onreadystatechange = function () {
    if (miLlamada.readyState < 4) {
        //aquí se puede poner una imagen de un reloj o un texto “Cargando”
    }
    else 
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            var arrayPokemon = JSON.parse(miLlamada.responseText);
            losPokemon(arrayPokemon);
        }
    };
    miLlamada.send();
}


function losPokemon(arrayPokemon){
    var lista = document.getElementById("lista");
    for (var i = 0; i < arrayPokemon.results.length; i++) {
        var li = document.createElement("li");
        li.appendChild(document.createTextNode(arrayPokemon.results[i].name));
        lista.appendChild(li);
    }
}