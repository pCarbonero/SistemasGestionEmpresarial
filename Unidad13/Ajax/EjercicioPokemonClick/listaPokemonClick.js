window.onload = pedirDatos;

function pedirDatos(){
    let miLlamada = new XMLHttpRequest();
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
    let lista = document.getElementById("lista");
    for (let i = 0; i < arrayPokemon.results.length; i++) {
        let li = document.createElement("li");
        li.id = arrayPokemon.results[i].name;
        li.onclick = () => mostrarPokemon(arrayPokemon.results[i].name);
        li.appendChild(document.createTextNode(arrayPokemon.results[i].name));
        lista.appendChild(li);
    }
}

function mostrarPokemon(miPokemon){
    let miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", `https://pokeapi.co/api/v2/pokemon/${miPokemon}`);

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            let pokemon = JSON.parse(miLlamada.responseText);

            let divPokemon = document.getElementById("divPokemon");
            divPokemon.innerHTML = "";

            let h1 = document.createElement("h1");
            h1.appendChild(document.createTextNode(pokemon.name));
            divPokemon.appendChild(h1);

            let img = document.createElement("img");
            img.src = pokemon.sprites.front_default;
            img.onclick = function(){
                if (img.src == pokemon.sprites.front_shiny){
                    img.src = pokemon.sprites.front_default;
                }
                else{
                    img.src = pokemon.sprites.front_shiny;
                }
            };
            divPokemon.appendChild(img);

            for (let i = 0; i < pokemon.stats.length; i++) {
                let statname = document.createElement("p");
                statname.appendChild(document.createTextNode(`${pokemon.stats[i].stat.name}: ${pokemon.stats[i].base_stat}`));
                divPokemon.appendChild(statname);

                let progress = document.createElement("progress");
                progress.max = 100;
                progress.value = pokemon.stats[i].base_stat;
                divPokemon.appendChild(progress);
            }
        }
        scroll(0,0);
    };

    miLlamada.send();
}