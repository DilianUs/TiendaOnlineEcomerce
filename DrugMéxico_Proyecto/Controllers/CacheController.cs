using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Runtime.Caching;
using MemoryCache = System.Runtime.Caching.MemoryCache;

namespace DrugMéxico_Proyecto.Controllers
{
    public class CacheController : Controller
    {
        public ObjectCache usuario= MemoryCache.Default;
       
    }
}
