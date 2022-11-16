using GizaSystems.AbpDemo.Authors.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace GizaSystems.AbpDemo.Authors
{// IApplicationService is a conventional interface that is inherited by all the application services,
 // so the ABP Framework can identify the service.
    public interface IAuthorAppService : IApplicationService
    {
        Task<AuthorDto> GetAsync(Guid id);
        Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input);
        Task<AuthorDto> CreateAsync(CreateAuthorDto input);
        Task UpdateAsync(Guid id, UpdateAuthorDto input);
        Task DeleteAsync(Guid id);
    }
}
