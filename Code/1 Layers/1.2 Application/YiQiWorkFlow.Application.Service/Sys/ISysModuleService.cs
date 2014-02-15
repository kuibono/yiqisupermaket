/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysModuleService
    {
        string Create(SysModule entity);

        SysModule GetById(string id);

        IList<SysModule> GetAll();

        void Update(SysModule entity);

        /// <summary>
        /// 删除指定SysModule
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysModule entity);

        /// <summary>
        /// SysModule
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysModule> entitys);


        SearchResult<SysModule> Search(SearchDtoBase<SysModule> c);
		
		IList<SysModule> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



