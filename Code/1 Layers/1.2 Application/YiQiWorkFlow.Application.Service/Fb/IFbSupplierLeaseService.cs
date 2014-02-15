/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbSupplierLeaseService
    {
        string Create(FbSupplierLease entity);

        FbSupplierLease GetById(string id);

        IList<FbSupplierLease> GetAll();

        void Update(FbSupplierLease entity);

        /// <summary>
        /// 删除指定FbSupplierLease
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbSupplierLease entity);

        /// <summary>
        /// FbSupplierLease
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbSupplierLease> entitys);


        SearchResult<FbSupplierLease> Search(SearchDtoBase<FbSupplierLease> c);
		
		IList<FbSupplierLease> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



