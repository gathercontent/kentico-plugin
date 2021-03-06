﻿namespace GatherContent.Connector.Managers.Models.ImportItems.New
{
  using GatherContent.Connector.Managers.Models.Mapping;

  public class ItemResultModel
  {
    public string CmsId { get; set; }

    public string CmsLink { get; set; }

    public GcItemModel GcItem { get; set; }

    public string GcLink { get; set; }

    public GcTemplateModel GcTemplate { get; set; }

    public string ImportMessage { get; set; }

    public bool IsImportSuccessful { get; set; }

    public GcStatusModel Status { get; set; }
  }
}