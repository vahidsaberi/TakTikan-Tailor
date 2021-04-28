using System.Collections.Generic;
using TakTikan.Tailor.Auditing.Dto;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
