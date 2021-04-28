using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TakTikan.Tailor.MultiTenancy.HostDashboard.Dto;

namespace TakTikan.Tailor.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}