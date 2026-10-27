using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands;

public class UpdateLeaveAllocationRequestHnadler : IRequestHandler<UpdateLeaveAllocationRequest , Unit>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;

    public UpdateLeaveAllocationRequestHnadler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
    {
        _mapper = mapper;
        _leaveAllocationRepository = leaveAllocationRepository;
    }

    public async Task<Unit> Handle(UpdateLeaveAllocationRequest request, CancellationToken cancellationToken)
    {
        var leaveAlocation = await _leaveAllocationRepository.Get((request.LeaveAllocationDto.Id));
        _mapper.Map(request.LeaveAllocationDto, leaveAlocation);
        await _leaveAllocationRepository.Update(leaveAlocation);
        return Unit.Value;
    }
}