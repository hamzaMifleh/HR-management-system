using MediatR;
using HR.LeaveManagement.Application.DTOs;
namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeListRequest  : IRequest<List<LeaveTypeDto>>
    {
        
    }
}