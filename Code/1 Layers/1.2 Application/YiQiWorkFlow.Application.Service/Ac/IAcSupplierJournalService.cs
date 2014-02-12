/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcSupplierJournalService
    {
        string Create(AcSupplierJournal entity);

        AcSupplierJournal GetById(string id);

        IList<AcSupplierJournal> GetAll();

        void Update(AcSupplierJournal entity);

        /// <summary>
        /// 删除指定AcSupplierJournal
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcSupplierJournal entity);

        /// <summary>
        /// AcSupplierJournal
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcSupplierJournal> entitys);


        SearchResult<AcSupplierJournal> Search(SearchDtoBase<AcSupplierJournal> c);
		
		IList<AcSupplierJournal> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



