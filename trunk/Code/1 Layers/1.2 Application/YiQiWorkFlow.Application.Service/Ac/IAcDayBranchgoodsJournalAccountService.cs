/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcDayBranchgoodsJournalAccountService
    {
        int Create(AcDayBranchgoodsJournalAccount entity);

        AcDayBranchgoodsJournalAccount GetById(int id);

        IList<AcDayBranchgoodsJournalAccount> GetAll();

        void Update(AcDayBranchgoodsJournalAccount entity);

        /// <summary>
        /// 删除指定AcDayBranchgoodsJournalAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcDayBranchgoodsJournalAccount entity);

        /// <summary>
        /// AcDayBranchgoodsJournalAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcDayBranchgoodsJournalAccount> entitys);


        SearchResult<AcDayBranchgoodsJournalAccount> Search(SearchDtoBase<AcDayBranchgoodsJournalAccount> c);
		
		IList<AcDayBranchgoodsJournalAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



