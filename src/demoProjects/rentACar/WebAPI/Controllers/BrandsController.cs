using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos.BrandDtos;
using Application.Features.Brands.Models;
using Application.Features.Brands.Queries.GetByIdBrand;
using Application.Features.Brands.Queries.GetListBrand;
using Core.Application.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost("brand-add")]
        public async Task<IActionResult> BrandAdd([FromBody] CreateBrandCommand createBrandCommand )
        {
            CreatedBrandDto cbd = await Mediator.Send(createBrandCommand);
            return Created("", cbd);
        }

        [HttpGet("brand-get-list")]
        public async Task<IActionResult> GetList([FromQuery]PageRequest pageRequest)
        {
            GetListBrandQuery data = new() { PageRequest = pageRequest };
            BrandListModel result = await Mediator.Send(data);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBrandQuery getByIdBrandQuery)
        {
            BrandGetByIdDto data = await Mediator.Send(getByIdBrandQuery);

            return Ok(data);
        }
    }
}
