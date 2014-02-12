/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcCashierSummaryService
    {
        string Create(AcCashierSummary entity);

        AcCashierSummary GetById(string id);

        IList<AcCashierSummary> GetAll();

        void Update(AcCashierSummary entity);

        /// <summary>
        /// 删除指定AcCashierSummary
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcCashierSummary entity);

        /// <summary>
        /// AcCashierSummary
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcCashierSummary> entitys);


        SearchResult<AcCashierSummary> Search(SearchDtoBase<AcCashierSummary> c);
		
		IList<AcCashierSummary> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



