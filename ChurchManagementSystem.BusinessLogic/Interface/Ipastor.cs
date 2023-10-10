using ChurchManagementSystem.Domain.Data_Transfer_Objects.Pastor;
using ChurchManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.BusinessLogic.Interface
{
    public interface Ipastor
    {
        Task<APIListResponse3<Pastor>> GetPastor(int pageNumber, int pageSize);
        Task<ApiResponse<Pastor>> GetSinglePastor(int Id);
        Task<ApiListResponse<CreatePastorDto>> CreatePastor(CreatePastorDto request);
        Task<ApiResponse<UpdatePastorDto>> UpdatePastor(UpdatePastorDto request);
       
    }
}

