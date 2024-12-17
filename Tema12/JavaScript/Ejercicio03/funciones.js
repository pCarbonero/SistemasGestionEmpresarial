class Marca{
    constructor(idMarca, nombreMarca) {
        this.idMarca = idMarca
        this.nombreMarca = nombreMarca
    }
}

class Modelo{
    constructor(idModelo, idMarca, nombreModelo) {
        this.idModelo = idModelo
        this.idMarca = idMarca
        this.nombreModelo = nombreModelo
    }
}

let listaMarcas = [
    new Marca(1, "Audi"),
    new Marca(2, "Mercedes"),
    new Marca(3, "Renault"),
    new Marca(4, "Seat"),
    new Marca(5, "Fiat")
]

let listaModelos = [
    new Modelo(1, 1, "Audi A6"),
    new Modelo(2, 2, "Mercedez-Benz"),
    new Modelo(3, 3, "Renault Megane"),
    new Modelo(4, 4, "Seat Leon"),
    new Modelo(5, 5, "Fiat 600"),
    new Modelo(6, 1, "Audi A3"),
    new Modelo(7, 2, "Mercedez-Campana"),
    new Modelo(8, 3, "Renault Clio"),
    new Modelo(9, 4, "Seat Ibiza"),
    new Modelo(10, 5, "Fiat 500")
]


function cargarListaMarcas(){
    for (let modelo of listaModelos){
        if (modelo.idMarca = document.getElementById("listaMarcas").value){
            let s = document.getElementById("modelos").append("<li>" + modelo.nombreModelo + "</li>")
        }
    } 
}

window.onload = function () {
    document.getElementById("listaMarcas").addEventListener("change", cargarListaMarcas);
};