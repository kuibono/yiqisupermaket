/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaSupplierDetailService
    {
        string Create(BaSupplierDetail entity);

        BaSupplierDetail GetById(string id);

        IList<BaSupplierDetail> GetAll();

        void Update(BaSupplierDetail entity);

        /// <summary>
        /// 删除指定BaSupplierDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaSupplierDetail entity);

        /// <summary>
        /// BaSupplierDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaSupplierDetail> entitys);


        SearchResult<BaSupplierDetail> Search(SearchDtoBase<BaSupplierDetail> c);
		
		IList<BaSupplierDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



