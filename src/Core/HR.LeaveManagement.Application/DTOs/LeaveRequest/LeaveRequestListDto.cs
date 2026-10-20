using HR.LeaveManagement.Application.DTOs.Common;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveRequestDto LeaveRequest { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}