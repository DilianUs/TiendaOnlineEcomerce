var currentPage = 1;
var totalPages = 185;

function showButtons() {
    var pagination = document.getElementById("pagination");
    pagination.innerHTML = "";
    pagination.appendChild(createButton("Anterior", prevPage));
    for (var i = currentPage; i < currentPage + 5 && i <= totalPages; i++) {
        pagination.appendChild(createButton(i, setPage));
    }
    pagination.appendChild(createButton("Siguiente", nextPage));
}
function createButton(text, onclick) {
    var button = document.createElement("button");
    button.innerHTML = text;
    button.onclick = onclick;
    button.setAttribute("id", "btnPaginaTienda");
    return button;
}
async function setPage() {
    currentPage = parseInt(this.innerHTML);
    showButtons();
    showPage();



    console.log("hola soy" + currentPage);

    axios.post('/Tienda/Shop/' + currentPage)
        .then(function (response) {
            console.log("exito");
            /*$('#cuerpo-productos').html(response.data);*/
            $('#cuerpo-productos').html(response.data);
           
        })
        .catch(function (error) {
            console.log(error);
        });

    var contenedor = document.getElementById("pagination");
    var botones = contenedor.querySelectorAll('button');

    botones.forEach(button => {
        console.log(button.innerHTML)
        console.log(currentPage)
        if (button.innerHTML === currentPage) {
            button.classList.add("current");
        } else {
            button.classList.remove("current");
        }
    });

}

function prevPage() {
    if (currentPage > 1) {
        currentPage--;
        showButtons();
        showPage();
    }
    console.log("hola soy" + currentPage);
    axios.post('/Tienda/Shop/' + currentPage)
        .then(function (response) {
            console.log("exito");
            /*$('#cuerpo-productos').html(response.data);*/
            $('#cuerpo-productos').html(response.data);

        })
        .catch(function (error) {
            console.log(error);
        });
}
function nextPage() {
    if (currentPage < totalPages) {
        currentPage++;
        showButtons();
        showPage();
    }
    console.log("hola soy" + currentPage);
    axios.post('/Tienda/Shop/' + currentPage)
        .then(function (response) {
            console.log("exito");
            /*$('#cuerpo-productos').html(response.data);*/
            $('#cuerpo-productos').html(response.data);

        })
        .catch(function (error) {
            console.log(error);
        });
}
function showPage() {
    var page = document.getElementById("page");
    page.innerHTML = "Página " + currentPage;

}

showButtons();
showPage();