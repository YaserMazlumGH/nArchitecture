using Application.Features.Brands.Dtos.BrandDtos;
using Core.Persistence.Paging;

namespace Application.Features.Brands.Models
{
    public class BrandListModel : BasePageableModel
    {
        public IList<BrandListDto> Items { get; set; }
    }
}
