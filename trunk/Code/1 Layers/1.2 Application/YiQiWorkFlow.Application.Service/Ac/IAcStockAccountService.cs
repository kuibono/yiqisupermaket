/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcStockAccountService
    {
        string Create(AcStockAccount entity);

        AcStockAccount GetById(string id);

        IList<AcStockAccount> GetAll();

        void Update(AcStockAccount entity);

        /// <summary>
        /// 删除指定AcStockAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcStockAccount entity);

        /// <summary>
        /// AcStockAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcStockAccount> entitys);


        SearchResult<AcStockAccount> Search(SearchDtoBase<AcStockAccount> c);
		
		IList<AcStockAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



