/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysOperationFlowService
    {
        string Create(SysOperationFlow entity);

        SysOperationFlow GetById(string id);

        IList<SysOperationFlow> GetAll();

        void Update(SysOperationFlow entity);

        /// <summary>
        /// 删除指定SysOperationFlow
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysOperationFlow entity);

        /// <summary>
        /// SysOperationFlow
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysOperationFlow> entitys);


        SearchResult<SysOperationFlow> Search(SearchDtoBase<SysOperationFlow> c);
		
		IList<SysOperationFlow> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



