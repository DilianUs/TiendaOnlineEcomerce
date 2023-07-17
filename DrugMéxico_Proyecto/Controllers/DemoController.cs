using DrugMéxico_Proyecto.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace DrugMéxico_Proyecto.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Vacunas()
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

        //Genericos 
        [HttpGet]
        public async Task<IActionResult> Genericos()
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

        //Patentes
        [HttpGet]
        public async Task<IActionResult> Patentes()
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

        //Controlados
        [HttpGet]
        public async Task<IActionResult> Controlados()
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
        //M. de curacion
        [HttpGet]
        public async Task<IActionResult> Curacion()
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

        //Mayoreo
        [HttpGet]
        public async Task<IActionResult>Mayoreo()
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

        [HttpGet]
        public async Task<IActionResult> Mayoreoo()
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
