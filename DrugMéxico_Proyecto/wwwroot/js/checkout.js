const form = document.getElementById('check-out-form');
const emailInput = document.getElementById('email');
const phoneInput = document.getElementById('phone');
const titular = document.getElementById("titular-name");
const numTag = document.getElementById("card-number");
const mes = document.getElementById("expiracion-cardM");
const year = document.getElementById("expiracion-cardY");
const cvv = document.getElementById("cvv-card");

form.addEventListener('submit', (event) => {
    if (!isValidEmail(emailInput.value)) {
        event.preventDefault();
        alert('Please enter a valid email address.' + emailInput.value);
    } else if (!isValidPhone(phoneInput.value)) {
        event.preventDefault();
        alert('Please enter a valid phone number.');
    } else if (titular === "") {
        event.preventDefault();
        alert('El nombre del titular es requerido');
    } else if (numTag === "") {
        event.preventDefault();
        alert('El numero de tarjeta del titular es requerido');
    } else if (mes === "") {
        event.preventDefault();
        alert('El mes de expiracion del titular es requerido');
    } else if (year === "") {
        event.preventDefault();
        alert('El año de expiracion del titular es requerido');
    } else if (cvv === "") {
        event.preventDefault();
        alert('El cvv del titular es requerido');
    }
        // else {
    //    event.preventDefault(); // prevenir el envío del formulario

    //    const datosFormulario = new FormData(form); // obtener los datos del formulario
    //    fetch('/Tienda/Checkout', {
    //        method: 'POST',
    //        body: datosFormulario
    //    })
    //        .then(response => response.text()) // manejar la respuesta del servidor
    //        .then(texto => {
    //            console.log(texto); // mostrar la respuesta en la consola
    //            const webviewDiv = document.getElementById("webview");

    //            // Crear el iframe
    //            const iframe = document.createElement("iframe");
    //            iframe.src = texto; // URL de la página web a incrustar
    //            iframe.width = "100%";
    //            iframe.height = "500px";

    //            // Agregar el iframe al div
    //            webviewDiv.appendChild(iframe);
    //            window.open(texto);
    //        })
    //        .catch(error => {
    //            console.error(error); // manejar errores
    //        });
    //}


});

function isValidEmail(email) {
    // Regular expression to validate email format
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}

function isValidPhone(phone) {
    // Regular expression to validate phone format
    const phoneRegex = /^\d{10}$/;
    return phoneRegex.test(phone);
}


