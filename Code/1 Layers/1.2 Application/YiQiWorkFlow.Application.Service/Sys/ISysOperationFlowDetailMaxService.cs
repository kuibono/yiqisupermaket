/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysOperationFlowDetailMaxService
    {
        string Create(SysOperationFlowDetailMax entity);

        SysOperationFlowDetailMax GetById(string id);

        IList<SysOperationFlowDetailMax> GetAll();

        void Update(SysOperationFlowDetailMax entity);

        /// <summary>
        /// 删除指定SysOperationFlowDetailMax
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysOperationFlowDetailMax entity);

        /// <summary>
        /// SysOperationFlowDetailMax
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysOperationFlowDetailMax> entitys);


        SearchResult<SysOperationFlowDetailMax> Search(SearchDtoBase<SysOperationFlowDetailMax> c);
		
		IList<SysOperationFlowDetailMax> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



