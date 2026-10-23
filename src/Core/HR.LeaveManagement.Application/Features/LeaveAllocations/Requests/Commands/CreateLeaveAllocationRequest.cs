using HR.LeaveManagement.Application.DTOs;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;

public class CreateLeaveAllocationRequest : IRequest<int>
{
    public LeaveAllocationDto LeaveAllocationDto { get; set; }
}