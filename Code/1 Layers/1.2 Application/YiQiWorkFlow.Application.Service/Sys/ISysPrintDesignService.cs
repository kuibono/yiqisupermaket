/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysPrintDesignService
    {
        string Create(SysPrintDesign entity);

        SysPrintDesign GetById(string id);

        IList<SysPrintDesign> GetAll();

        void Update(SysPrintDesign entity);

        /// <summary>
        /// 删除指定SysPrintDesign
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysPrintDesign entity);

        /// <summary>
        /// SysPrintDesign
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysPrintDesign> entitys);


        SearchResult<SysPrintDesign> Search(SearchDtoBase<SysPrintDesign> c);
		
		IList<SysPrintDesign> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



