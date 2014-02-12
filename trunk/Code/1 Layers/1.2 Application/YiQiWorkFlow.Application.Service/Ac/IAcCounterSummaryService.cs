/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcCounterSummaryService
    {
        string Create(AcCounterSummary entity);

        AcCounterSummary GetById(string id);

        IList<AcCounterSummary> GetAll();

        void Update(AcCounterSummary entity);

        /// <summary>
        /// 删除指定AcCounterSummary
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcCounterSummary entity);

        /// <summary>
        /// AcCounterSummary
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcCounterSummary> entitys);


        SearchResult<AcCounterSummary> Search(SearchDtoBase<AcCounterSummary> c);
		
		IList<AcCounterSummary> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



