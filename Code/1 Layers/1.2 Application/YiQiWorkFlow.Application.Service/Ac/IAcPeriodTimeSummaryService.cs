/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcPeriodTimeSummaryService
    {
        int Create(AcPeriodTimeSummary entity);

        AcPeriodTimeSummary GetById(int id);

        IList<AcPeriodTimeSummary> GetAll();

        void Update(AcPeriodTimeSummary entity);

        /// <summary>
        /// 删除指定AcPeriodTimeSummary
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcPeriodTimeSummary entity);

        /// <summary>
        /// AcPeriodTimeSummary
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcPeriodTimeSummary> entitys);


        SearchResult<AcPeriodTimeSummary> Search(SearchDtoBase<AcPeriodTimeSummary> c);
		
		IList<AcPeriodTimeSummary> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



