/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysLoginPowerService
    {
        string Create(SysLoginPower entity);

        SysLoginPower GetById(string id);

        IList<SysLoginPower> GetAll();

        void Update(SysLoginPower entity);

        /// <summary>
        /// 删除指定SysLoginPower
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysLoginPower entity);

        /// <summary>
        /// SysLoginPower
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysLoginPower> entitys);


        SearchResult<SysLoginPower> Search(SearchDtoBase<SysLoginPower> c);
		
		IList<SysLoginPower> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



