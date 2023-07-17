function activeSesion() {
    
    var element = document.querySelector(".tabs-panel-sesion");
    var secondElement = document.querySelector(".tabs-panel-cuenta");

    
        secondElement.classList.remove("cuenta-active");
        document.querySelector(".cuenta-text").classList.remove("active");

        element.classList.add("sesion-active");
        document.querySelector(".sesion-text").classList.add("active");
        
        
   

}

function activeCuenta() {
    
    var element = document.querySelector(".tabs-panel-cuenta");
    var secondElement = document.querySelector(".tabs-panel-sesion");

    secondElement.classList.remove("sesion-active");
    document.querySelector(".sesion-text").classList.remove("active");

    element.classList.add("cuenta-active");
    document.querySelector(".cuenta-text").classList.add("active");
        
    

}

      