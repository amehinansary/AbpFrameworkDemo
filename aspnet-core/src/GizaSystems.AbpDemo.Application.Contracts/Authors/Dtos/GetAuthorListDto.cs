using Volo.Abp.Application.Dtos;

namespace GizaSystems.AbpDemo.Authors.Dtos
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; } = string.Empty;
    }
}
