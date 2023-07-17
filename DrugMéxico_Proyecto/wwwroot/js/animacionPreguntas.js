//function seleccionar(id) {
//    let listaPreguntas = document.querySelectorAll(".dropdown-check");
//    i = 0;
//    listaPreguntas.forEach((e) => { 
//        var idActual = e.getAttribute("id");
//        i++;
//        if (idActual != id) {
//            console.log("#pregunta" + i);
//           $("#pregunta" + i).prop('checked', false);
//        };
//    });       
//}
function seleccionar(id) {
    let listaPreguntas = document.querySelectorAll(".dropdown-check");
    i = 0;
    listaPreguntas.forEach((e) => {
        var idActual = e.getAttribute("id");
        i++;
        if (idActual != id) {
            console.log("#pregunta" + i);
            if ($("#pregunta" + i).is(":checked")) {
                $("#pregunta" + i).prop('checked', false);
                $(".dropdown-element" + i).slideUp();
            }
        }
    });
}

var elemento = document.querySelector("#promotion-header");
var visible = true;

function quitarPromo() {
    console.log("hola")
    elemento.style.display = "none";
}