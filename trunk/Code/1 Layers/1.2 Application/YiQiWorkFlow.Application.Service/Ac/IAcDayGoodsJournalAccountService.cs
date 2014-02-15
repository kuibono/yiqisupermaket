/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcDayGoodsJournalAccountService
    {
        int Create(AcDayGoodsJournalAccount entity);

        AcDayGoodsJournalAccount GetById(int id);

        IList<AcDayGoodsJournalAccount> GetAll();

        void Update(AcDayGoodsJournalAccount entity);

        /// <summary>
        /// 删除指定AcDayGoodsJournalAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcDayGoodsJournalAccount entity);

        /// <summary>
        /// AcDayGoodsJournalAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcDayGoodsJournalAccount> entitys);


        SearchResult<AcDayGoodsJournalAccount> Search(SearchDtoBase<AcDayGoodsJournalAccount> c);
		
		IList<AcDayGoodsJournalAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



