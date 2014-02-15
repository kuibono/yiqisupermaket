/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbAdjustSupplierService
    {
        string Create(FbAdjustSupplier entity);

        FbAdjustSupplier GetById(string id);

        IList<FbAdjustSupplier> GetAll();

        void Update(FbAdjustSupplier entity);

        /// <summary>
        /// 删除指定FbAdjustSupplier
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbAdjustSupplier entity);

        /// <summary>
        /// FbAdjustSupplier
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbAdjustSupplier> entitys);


        SearchResult<FbAdjustSupplier> Search(SearchDtoBase<FbAdjustSupplier> c);
		
		IList<FbAdjustSupplier> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



