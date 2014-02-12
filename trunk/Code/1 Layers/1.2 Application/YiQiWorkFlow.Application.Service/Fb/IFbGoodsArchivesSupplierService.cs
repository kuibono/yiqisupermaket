/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbGoodsArchivesSupplierService
    {
        string Create(FbGoodsArchivesSupplier entity);

        FbGoodsArchivesSupplier GetById(string id);

        IList<FbGoodsArchivesSupplier> GetAll();

        void Update(FbGoodsArchivesSupplier entity);

        /// <summary>
        /// 删除指定FbGoodsArchivesSupplier
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbGoodsArchivesSupplier entity);

        /// <summary>
        /// FbGoodsArchivesSupplier
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbGoodsArchivesSupplier> entitys);


        SearchResult<FbGoodsArchivesSupplier> Search(SearchDtoBase<FbGoodsArchivesSupplier> c);
		
		IList<FbGoodsArchivesSupplier> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



