using System.Collections.Generic;
using Abp;
using TakTikan.Tailor.Chat.Dto;
using TakTikan.Tailor.Dto;

namespace TakTikan.Tailor.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
