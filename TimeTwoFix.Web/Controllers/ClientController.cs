using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TimeTwoFix.Application.ClientServices.Dtos;
using TimeTwoFix.Core.Entities.ClientManagement;
using TimeTwoFix.Core.Interfaces;
using TimeTwoFix.Web.Models.ClientModels;

namespace TimeTwoFix.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ClientController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: ClientController
        public async Task<IActionResult> Index()
        {
            var clients = await _unitOfWork.Clients.GetAllAsyncGeneric();
            var clientsDto = _mapper.Map<IEnumerable<ReadClientDto>>(clients);
            var clientsViewModel = _mapper.Map<IEnumerable<ReadClientViewModel>>(clientsDto);

            return View(clientsViewModel);
        }

        // GET: ClientController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                var client = await _unitOfWork.Clients.GetByIdAsyncGeneric(id);
                if (client == null)
                {
                    return NotFound();
                }
                var clientDto = _mapper.Map<ReadClientDto>(client);
                var clientViewModel = _mapper.Map<ReadClientViewModel>(clientDto);
                return View(clientViewModel);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateClientViewModel createClientViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(createClientViewModel);
                }
                var clientDto = _mapper.Map<CreateClientDto>(createClientViewModel);
                var client = _mapper.Map<Client>(clientDto);
                var addedElement = await _unitOfWork.Clients.AddAsyncGeneric(client);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var client = await _unitOfWork.Clients.GetByIdAsyncGeneric(id);
            var clientDto = _mapper.Map<UpdateClientDto>(client);
            var clientView = _mapper.Map<UpdateClientViewModel>(clientDto);

            return View(clientView);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(UpdateClientViewModel updateClientViewModel)
        {
            try
            {
                var client = await _unitOfWork.Clients.GetByIdAsyncGeneric(updateClientViewModel.Id);
                if (client == null)
                {
                    return NotFound();
                }
                var clientDto = _mapper.Map<UpdateClientDto>(updateClientViewModel);

                var updatedClient = _mapper.Map(clientDto, client);
                //updatedClient.UpdatedAt = DateTime.UtcNow;
                await _unitOfWork.Clients.UpdateAsyncGeneric(updatedClient);
                await _unitOfWork.SaveChangesAsync();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
