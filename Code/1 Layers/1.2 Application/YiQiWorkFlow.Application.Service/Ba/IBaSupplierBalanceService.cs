/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaSupplierBalanceService
    {
        string Create(BaSupplierBalance entity);

        BaSupplierBalance GetById(string id);

        IList<BaSupplierBalance> GetAll();

        void Update(BaSupplierBalance entity);

        /// <summary>
        /// 删除指定BaSupplierBalance
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaSupplierBalance entity);

        /// <summary>
        /// BaSupplierBalance
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaSupplierBalance> entitys);


        SearchResult<BaSupplierBalance> Search(SearchDtoBase<BaSupplierBalance> c);
		
		IList<BaSupplierBalance> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



