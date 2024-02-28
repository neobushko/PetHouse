using AutoMapper;
using BissnessLayer.Handlers.PetHandler.PetAdd;
using BissnessLayer.Handlers.PetHandler.PetChangeName;
using BissnessLayer.Handlers.PetHandler.PetChangeStatus;
using BissnessLayer.Interfaces;
using Core.Exceptions;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace PetHouseAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : Controller
{
    private readonly IMapper _mapper;
    private readonly IPetService _service;

    public PetController(IMapper mapper, IPetService service)
    {
        _mapper = mapper;
        _service = service;
    }

    /// <summary>
    /// Gets all pets
    /// </summary>
    /// <returns>All created active pets from DB</returns>
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAllPetsAsync());
    }

    [HttpGet("{petId}")]
    public async Task<IActionResult> GetPet(Guid petId)
    {
        try
        {
            return Ok(await _service.GetPetAsync(petId));
        }
        catch (EntityNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> AddPet(PetAddRequest request)
    {
        return Ok(await _service.AddPetAsync(request));
    }

    [HttpPatch("ChangeName")]
    public async Task<IActionResult> ChangePetName([FromBody] PetChangeNameRequest request)
    {
        try
        {
            return Ok(await _service.ChangeNameAsync(request));
        }
        catch (EntityNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPatch("ChangeStatus")]
    public async Task<IActionResult> ChangePetStatus([FromBody] PetChangeStatusRequest request)
    {
        try
        {
            return Ok(await _service.ChangeStatusAsync(request));
        }
        catch (EntityNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
