using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;

public class CreateLeaveRequestRequest : IRequest<int>
{
    public LeaveRequestDto LeaveRequestDto { get; set; }
}