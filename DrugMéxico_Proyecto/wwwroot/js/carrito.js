//actualizacion de cantidad de productos en carrito
document.addEventListener('DOMContentLoaded', function () {
    const plusButtons = document.querySelectorAll('.plus-carrito-cant');
    const minusButtons = document.querySelectorAll('.minus-carrito-cant');

    plusButtons.forEach( function (button) {
        button.addEventListener('click', async function () {
            const idCarrito = this.closest('.counter').querySelector('.id-carrito-container').textContent;
            const cantidadContainer = this.closest('.counter').querySelector('.cantidad-productos');
            let currentValue = parseInt(cantidadContainer.textContent);
            currentValue++;
            cantidadContainer.textContent = currentValue;
            console.log(idCarrito);

            const formData = new FormData();
            formData.append('idCarrito', idCarrito);
            formData.append('cantdadProducto', currentValue);
            const url = `/Usuario/ActualizarCarrito`;
            try {
                const response = await fetch(url, {
                    method: 'POST',
                    body: formData
                });

                if (response.ok) {
                    console.log('Llamada a la función ASP.NET realizada con éxito');
                } else {
                    console.error('Error al realizar la llamada a la función ASP.NET:', response.statusText);
                }
            } catch (error) {
                console.error('Error al realizar la llamada a la función ASP.NET:', error);
            }
        });
    });

    minusButtons.forEach(function (button) {
        button.addEventListener('click', async function () {
            const idCarrito = this.closest('.counter').querySelector('.id-carrito-container').textContent;
            const cantidadContainer = this.closest('.counter').querySelector('.cantidad-productos');
            let currentValue = parseInt(cantidadContainer.textContent);
            currentValue--;
            cantidadContainer.textContent = currentValue;
            console.log(idCarrito);
            const formData = new FormData();
            formData.append('idCarrito', idCarrito);
            formData.append('cantdadProducto', currentValue);
            const url = `/Usuario/ActualizarCarrito`;
            try {
                const response = await fetch(url, {
                    method: 'POST',
                    body: formData
                });

                if (response.ok) {
                    console.log('Llamada a la función ASP.NET realizada con éxito');
                } else {
                    console.error('Error al realizar la llamada a la función ASP.NET:', response.statusText);
                }
            } catch (error) {
                console.error('Error al realizar la llamada a la función ASP.NET:', error);
            }
        });
    });
});



//contador en detalles producto para añadir a carrito
const input = document.querySelector('input[name="cantidadProducto"]');
const upButton = document.querySelector('.up');
const downButton = document.querySelector('.down');
const inputEnvio = document.querySelector("#cantidad-produncto-enviar");
upButton.addEventListener('click', () => {
    let currentValue = parseInt(input.value);
    currentValue++;
    input.value = currentValue >= 0 ? currentValue : 0;
    inputEnvio.value = currentValue >= 0 ? currentValue : 0;
    console.log(inputEnvio.value);
});

downButton.addEventListener('click', () => {
    let currentValue = parseInt(input.value);
    currentValue--;
    input.value = currentValue >= 0 ? currentValue : 0;

    inputEnvio.value = currentValue >= 0 ? currentValue : 0;
    console.log(inputEnvio.value);
});

input.addEventListener('input', function () {
    inputEnvio.value = input.value;
    console.log(inputEnvio.value);
});