/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcDayGoodsstockJournalAccountTempService
    {
        string Create(AcDayGoodsstockJournalAccountTemp entity);

        AcDayGoodsstockJournalAccountTemp GetById(string id);

        IList<AcDayGoodsstockJournalAccountTemp> GetAll();

        void Update(AcDayGoodsstockJournalAccountTemp entity);

        /// <summary>
        /// 删除指定AcDayGoodsstockJournalAccountTemp
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcDayGoodsstockJournalAccountTemp entity);

        /// <summary>
        /// AcDayGoodsstockJournalAccountTemp
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcDayGoodsstockJournalAccountTemp> entitys);


        SearchResult<AcDayGoodsstockJournalAccountTemp> Search(SearchDtoBase<AcDayGoodsstockJournalAccountTemp> c);
		
		IList<AcDayGoodsstockJournalAccountTemp> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



