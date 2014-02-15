/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcMonthGoodsJournalAccountService
    {
        int Create(AcMonthGoodsJournalAccount entity);

        AcMonthGoodsJournalAccount GetById(int id);

        IList<AcMonthGoodsJournalAccount> GetAll();

        void Update(AcMonthGoodsJournalAccount entity);

        /// <summary>
        /// 删除指定AcMonthGoodsJournalAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcMonthGoodsJournalAccount entity);

        /// <summary>
        /// AcMonthGoodsJournalAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcMonthGoodsJournalAccount> entitys);


        SearchResult<AcMonthGoodsJournalAccount> Search(SearchDtoBase<AcMonthGoodsJournalAccount> c);
		
		IList<AcMonthGoodsJournalAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



