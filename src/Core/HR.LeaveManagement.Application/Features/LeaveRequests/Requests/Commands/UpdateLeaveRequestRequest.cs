using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;

public class UpdateLeaveRequestRequest : IRequest<Unit>
{
    public int Id { get; set; }
    public LeaveTypeDto LeaveTypeDto { get; set; }
    public  ChangeLeaveRequestApprovalDto changeLeaveRequestApprovalDto { get; set; }
}