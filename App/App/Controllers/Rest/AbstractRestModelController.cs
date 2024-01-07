using App.Persistence.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers.Rest
{

    public abstract class AbstractRestModelController<M,K,S> : Controller where S : PersistenceService<M,K>
    {
        protected S service;
        public AbstractRestModelController(S service)
        {
            this.service = service;
        }
        protected IActionResult Create(M entity)
        {
            service.Create(entity);
            return new AcceptedResult();
        }
    }
}
