/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysModuleContentService
    {
        string Create(SysModuleContent entity);

        SysModuleContent GetById(string id);

        IList<SysModuleContent> GetAll();

        void Update(SysModuleContent entity);

        /// <summary>
        /// 删除指定SysModuleContent
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysModuleContent entity);

        /// <summary>
        /// SysModuleContent
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysModuleContent> entitys);


        SearchResult<SysModuleContent> Search(SearchDtoBase<SysModuleContent> c);
		
		IList<SysModuleContent> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



