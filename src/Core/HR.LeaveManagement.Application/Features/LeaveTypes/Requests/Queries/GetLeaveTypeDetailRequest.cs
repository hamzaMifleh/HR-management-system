using HR.LeaveManagement.Application.DTOs;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests;

public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>, IRequest<LeaveAllocationDto>
{
    public int Id { get; set; }
}