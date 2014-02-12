/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcDayGoodsJournalAccountTempService
    {
        string Create(AcDayGoodsJournalAccountTemp entity);

        AcDayGoodsJournalAccountTemp GetById(string id);

        IList<AcDayGoodsJournalAccountTemp> GetAll();

        void Update(AcDayGoodsJournalAccountTemp entity);

        /// <summary>
        /// 删除指定AcDayGoodsJournalAccountTemp
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcDayGoodsJournalAccountTemp entity);

        /// <summary>
        /// AcDayGoodsJournalAccountTemp
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcDayGoodsJournalAccountTemp> entitys);


        SearchResult<AcDayGoodsJournalAccountTemp> Search(SearchDtoBase<AcDayGoodsJournalAccountTemp> c);
		
		IList<AcDayGoodsJournalAccountTemp> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



