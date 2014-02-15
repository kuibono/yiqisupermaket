/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcMonthClassJournalAccountService
    {
        int Create(AcMonthClassJournalAccount entity);

        AcMonthClassJournalAccount GetById(int id);

        IList<AcMonthClassJournalAccount> GetAll();

        void Update(AcMonthClassJournalAccount entity);

        /// <summary>
        /// 删除指定AcMonthClassJournalAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcMonthClassJournalAccount entity);

        /// <summary>
        /// AcMonthClassJournalAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcMonthClassJournalAccount> entitys);


        SearchResult<AcMonthClassJournalAccount> Search(SearchDtoBase<AcMonthClassJournalAccount> c);
		
		IList<AcMonthClassJournalAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



