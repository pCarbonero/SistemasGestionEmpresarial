function pedirDatos(){
    pokemon = document.getElementById("txtPokemon").value;
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "https://pokeapi.co/api/v2/pokemon/"+pokemon);
    //Definicion estados
    miLlamada.onreadystatechange = function () {
    if (miLlamada.readyState < 4) {
        //aquí se puede poner una imagen de un reloj o un texto “Cargando”
    }
    else 
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            var miPokemon = JSON.parse(miLlamada.responseText);
            losPokemon(miPokemon);
        }
    };
    miLlamada.send();
}


function losPokemon(miPokemon){
    var divPokemon = document.getElementById("divPokemon");
    var h1 = document.createElement("h1");
    h1.appendChild(document.createTextNode(miPokemon.name));
    divPokemon.appendChild(h1);
    var img = document.createElement("img");
    img.src = miPokemon.sprites.front_default;
    divPokemon.appendChild(img);
}