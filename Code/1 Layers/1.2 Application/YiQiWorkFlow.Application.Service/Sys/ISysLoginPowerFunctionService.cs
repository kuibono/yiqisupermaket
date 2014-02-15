/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysLoginPowerFunctionService
    {
        string Create(SysLoginPowerFunction entity);

        SysLoginPowerFunction GetById(string id);

        IList<SysLoginPowerFunction> GetAll();

        void Update(SysLoginPowerFunction entity);

        /// <summary>
        /// 删除指定SysLoginPowerFunction
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysLoginPowerFunction entity);

        /// <summary>
        /// SysLoginPowerFunction
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysLoginPowerFunction> entitys);


        SearchResult<SysLoginPowerFunction> Search(SearchDtoBase<SysLoginPowerFunction> c);
		
		IList<SysLoginPowerFunction> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



