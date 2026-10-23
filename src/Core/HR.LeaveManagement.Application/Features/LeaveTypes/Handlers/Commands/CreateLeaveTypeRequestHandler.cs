using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands;

public class CreateLeaveTypeRequestHandler : IRequestHandler<CreateLeaveTypeRequest , int>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public CreateLeaveTypeRequestHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _mapper = mapper;
        _leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<int> Handle(CreateLeaveTypeRequest request, CancellationToken cancellationToken)
    {
        var leavetype = _mapper.Map<LeaveType>(request.LeaveTypeDto);
        leavetype = await _leaveTypeRepository.Add(leavetype);
        return leavetype.Id;

    }
}