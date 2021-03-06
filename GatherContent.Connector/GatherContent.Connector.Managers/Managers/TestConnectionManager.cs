﻿namespace GatherContent.Connector.Managers.Managers
{
  using GatherContent.Connector.GatherContentService.Interfaces;
  using GatherContent.Connector.Managers.Interfaces;

  /// <summary>
  /// 
  /// </summary>
  public class TestConnectionManager : BaseManager
  {
    /// <summary>
    /// 
    /// </summary>
    public TestConnectionManager(IAccountsService accountsService, IProjectsService projectsService, ITemplatesService templateService, ICacheManager cacheManager)
      : base(accountsService, projectsService, templateService, cacheManager)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool TestConnection()
    {
      try
      {
        this.AccountsService.GetAccounts();
      }
      catch
      {
        return false;
      }

      return true;
    }
  }
}