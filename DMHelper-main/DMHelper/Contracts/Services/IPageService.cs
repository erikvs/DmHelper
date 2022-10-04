using System;

namespace DMHelper.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
