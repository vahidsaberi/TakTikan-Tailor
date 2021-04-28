﻿using Abp.Application.Services.Dto;
using Abp.Webhooks;
using TakTikan.Tailor.WebHooks.Dto;

namespace TakTikan.Tailor.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
