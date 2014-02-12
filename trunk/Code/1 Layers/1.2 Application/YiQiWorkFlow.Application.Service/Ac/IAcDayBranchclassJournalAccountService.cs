/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcDayBranchclassJournalAccountService
    {
        string Create(AcDayBranchclassJournalAccount entity);

        AcDayBranchclassJournalAccount GetById(string id);

        IList<AcDayBranchclassJournalAccount> GetAll();

        void Update(AcDayBranchclassJournalAccount entity);

        /// <summary>
        /// 删除指定AcDayBranchclassJournalAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcDayBranchclassJournalAccount entity);

        /// <summary>
        /// AcDayBranchclassJournalAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcDayBranchclassJournalAccount> entitys);


        SearchResult<AcDayBranchclassJournalAccount> Search(SearchDtoBase<AcDayBranchclassJournalAccount> c);
		
		IList<AcDayBranchclassJournalAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



