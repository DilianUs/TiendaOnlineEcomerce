using DrugMéxico_Proyecto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//openpay
using Openpay;
using Openpay.Entities;
using Openpay.Entities.Request;
using System.Text.Json;
using Microsoft.JSInterop;
using System.Net.Http;

namespace DrugMéxico_Proyecto.Controllers
{
    public class TiendaController : Controller
    {

        private OpenpayAPI openpayAPI = new OpenpayAPI("sk_914de389c3a7405d914eb3a10ab7173e", "mqmsrg8kqp8emsh76dgj");
        private readonly IJSRuntime _jsRuntime;
        //public string urlPago;
        public TiendaController(IJSRuntime jsRuntime) {
            _jsRuntime = jsRuntime;
        }


        //public IActionResult Shop()
        //{
        //    return View();
        //}

        //[HttpPost]
        public  IActionResult Shop(string urlPago) {

            List<ProductoModel> dat = new List<ProductoModel>();
            

            
            return View(dat);
            
          
           
        }

        [HttpPost]
        [Route("/Tienda/Shop/{id}")]
        public IActionResult Shop(int id)
        {

            List<ProductoModel> dat = new List<ProductoModel>();

            
            return PartialView("_ProductosParcial",dat);
        }



        public  IActionResult ProductoDetalle(string id)
        {

            

                    //RestResponse response = GetProductByIDAsync(id);
                    //ProductoModel producto = new ProductoModel();
                    //if (response.StatusCode == HttpStatusCode.OK)
                    //{

                    //    producto = JsonConvert.DeserializeObject<ProductoModel>(response.Content);

                    //    ViewBag.prueba = producto;
                    //    return View(producto);
                    //}
                    //else
                    ViewBag.id = id;
            return View();




        }




        public IActionResult Checkout(string id)
        {
            

                        return View();
                 
  
        }

        //openpay experimento
        [HttpPost]
        public  IActionResult Checkout(IFormCollection form)
        {
        
           
                
                return RedirectToAction("transferencia", new { producto = form["nombre-Producto"],precio = form["total"], mail = form["email"], nombre = form["name"] });
           
           
        }

       

        public IActionResult transferencia(string producto,string precio,string mail,string nombre) {
            
            ViewBag.producto = producto;
            ViewBag.precio = precio;
            ViewBag.mail = mail;
            ViewBag.nombre = nombre;
            return View();
        }

        //original de cesar
        //public async Task<IActionResult> ProductoDetalle(string id)
        //{

        //    var options = new RestClientOptions("https://keen-napier.68-168-208-58.plesk.page")
        //    {
        //        MaxTimeout = -1,
        //    };
        //    var client = new RestClient(options);
        //    var request = new RestRequest("/api/ProductoGral/GetProductoById", Method.Post);
        //    request.AddHeader("Content-Type", "application/json");
        //    var body = @"{" + "\n" + @"  ""id"": " + id + " \n" + @"}";

        //    request.AddStringBody(body, DataFormat.Json);
        //    RestResponse response = await client.ExecuteAsync(request);
        //    ProductoModel producto = new ProductoModel();
        //    if (response.StatusCode == HttpStatusCode.OK)
        //    {

        //        producto = JsonConvert.DeserializeObject<ProductoModel>(response.Content);




        //        ViewBag.producto = producto;
        //        return View(producto);
        //    }
        //    else
        //    {
        //        return RedirectToAction("Shop");

        //    }
        //}



        //obtener 1 producto por id
        public RestResponse GetProductByIDAsync(String id)
        {

            var options = new RestClientOptions("https://keen-napier.68-168-208-58.plesk.page")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);
            var request = new RestRequest("/api/ProductoGral/GetProductoById", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" + @"  ""id"": " + id + " \n" + @"}";

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);


            return response;
        }

        [HttpGet]
        public async Task<IActionResult> Oferta()
        {
            string usuariosApiUrl = "https://keen-napier.68-168-208-58.plesk.page/api/CRM/OfertasDelDia";




            using (HttpClient client = new HttpClient())
            {


                HttpResponseMessage usuariosResponse = await client.GetAsync(usuariosApiUrl);


                if (usuariosResponse.IsSuccessStatusCode)
                {
                    string usuariosResponseBody = await usuariosResponse.Content.ReadAsStringAsync();


                    // Deserializar el JSON en una lista de objetos de usuario y de direcciones
                    List<OfertasModel> ofertas = JsonConvert.DeserializeObject<List<OfertasModel>>(usuariosResponseBody);

                    //// Combinar la lista de usuarios y la lista de direcciones en el modelo Usuarios
                    var model = new OfertasModel
                    {
                        Ofertas = ofertas,

                    };

                    //
                    // Devolver el modelo Usuarios a la vista
                    return View(model);
                }
                else
                {
                    Console.WriteLine("Error: " + usuariosResponse.StatusCode);
                    return StatusCode((int)usuariosResponse.StatusCode);
                }
            }
        }


    }
}
