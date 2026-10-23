using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands;

public class CreateLeaveRequestRequestHandler : IRequestHandler<CreateLeaveRequestRequest , int >
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;

    public CreateLeaveRequestRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateLeaveRequestRequest request, CancellationToken cancellationToken)
    {
        var leaveRequest =  _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
        leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
        return leaveRequest.Id;
    }
}