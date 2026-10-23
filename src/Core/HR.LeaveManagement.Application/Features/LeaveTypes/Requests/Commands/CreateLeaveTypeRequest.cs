using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;

public class CreateLeaveTypeRequest : IRequest<int>
{
    public LeaveTypeDto LeaveTypeDto { get; set; }
}