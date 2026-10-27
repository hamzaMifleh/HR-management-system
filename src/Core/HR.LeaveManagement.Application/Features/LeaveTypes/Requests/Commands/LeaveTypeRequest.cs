using HR.LeaveManagement.Application.DTOs;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;

public class LeaveTypeRequest : IRequest<Unit>
{
    public LeaveTypeDto leaveTypeDto { get; set; }
}