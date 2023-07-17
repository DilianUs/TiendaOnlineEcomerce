using DrugMéxico_Proyecto.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DrugMéxico_Proyecto.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IConfiguration _configuration;

        public UsuarioController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Usuario()
        {

           
                    return RedirectToAction("My_Account");
          
       
        }

        public IActionResult My_Account() {
          
                return View();
            

            
           
        }


        public IActionResult SignIn() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserModel userModel)
        {
            
                    return RedirectToAction("Usuario");
               
           

        }

        public IActionResult SignOut()
        {
            

            return RedirectToAction("Usuario");



        }


        public IActionResult Carrito() {
            
                    
                        
                        return View();

           
        }

        [HttpPost]
        public async Task<IActionResult> Carrito(string id,string cantidadProducto)
        {
            

                     
                        return RedirectToAction("Carrito", "Usuario");
                   

        }

        [HttpPost]
        public IActionResult ActualizarCarrito(string idCarrito,string cantdadProducto)
        {
           

                return Ok();
         

        }


    }
}
