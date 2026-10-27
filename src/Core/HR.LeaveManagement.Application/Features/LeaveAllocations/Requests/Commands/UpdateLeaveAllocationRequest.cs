using HR.LeaveManagement.Application.DTOs;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;

public class UpdateLeaveAllocationRequest : IRequest<Unit>
{
    public LeaveAllocationDto LeaveAllocationDto { get; set; }
}