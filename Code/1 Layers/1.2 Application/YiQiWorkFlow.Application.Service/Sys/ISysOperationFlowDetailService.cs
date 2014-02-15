/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysOperationFlowDetailService
    {
        string Create(SysOperationFlowDetail entity);

        SysOperationFlowDetail GetById(string id);

        IList<SysOperationFlowDetail> GetAll();

        void Update(SysOperationFlowDetail entity);

        /// <summary>
        /// 删除指定SysOperationFlowDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysOperationFlowDetail entity);

        /// <summary>
        /// SysOperationFlowDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysOperationFlowDetail> entitys);


        SearchResult<SysOperationFlowDetail> Search(SearchDtoBase<SysOperationFlowDetail> c);
		
		IList<SysOperationFlowDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



