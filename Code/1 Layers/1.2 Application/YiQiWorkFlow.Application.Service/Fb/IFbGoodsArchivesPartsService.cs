/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbGoodsArchivesPartsService
    {
        string Create(FbGoodsArchivesParts entity);

        FbGoodsArchivesParts GetById(string id);

        IList<FbGoodsArchivesParts> GetAll();

        void Update(FbGoodsArchivesParts entity);

        /// <summary>
        /// 删除指定FbGoodsArchivesParts
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbGoodsArchivesParts entity);

        /// <summary>
        /// FbGoodsArchivesParts
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbGoodsArchivesParts> entitys);


        SearchResult<FbGoodsArchivesParts> Search(SearchDtoBase<FbGoodsArchivesParts> c);
		
		IList<FbGoodsArchivesParts> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



