﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.CustomActionFilters;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWalkRepository _walkRepository;
        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            _mapper = mapper;
            _walkRepository = walkRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery)
        {
            var walksDomainModel = await _walkRepository.GetAllAsync(filterOn, filterQuery);
            return Ok(_mapper.Map<List<WalkDto>>(walksDomainModel));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var walkDomainModel = await _walkRepository.GetByIdAsync(id);

            if (walkDomainModel == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<WalkDto>(walkDomainModel));
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDto addWalkRequest)
        {
            var walkDomainModel = _mapper.Map<Walk>(addWalkRequest);
            await _walkRepository.CreatAsync(walkDomainModel);
            return Ok(_mapper.Map<WalkDto>(walkDomainModel));
        }

        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, UpdateWalkRequestDto requestDto)
        {
            var walkDomainModel = _mapper.Map<Walk>(requestDto);

            walkDomainModel = await _walkRepository.UpdateAsync(id, walkDomainModel);

            if (walkDomainModel == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<WalkDto>(walkDomainModel));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deleteWalkDomainModel = await _walkRepository.DeleteAsync(id);

            if (deleteWalkDomainModel == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<WalkDto>(deleteWalkDomainModel));
        }
    }
}
