using System;
using Abp.Notifications;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}