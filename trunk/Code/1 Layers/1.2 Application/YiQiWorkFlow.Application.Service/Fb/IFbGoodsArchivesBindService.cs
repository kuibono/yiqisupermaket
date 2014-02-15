/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbGoodsArchivesBindService
    {
        string Create(FbGoodsArchivesBind entity);

        FbGoodsArchivesBind GetById(string id);

        IList<FbGoodsArchivesBind> GetAll();

        void Update(FbGoodsArchivesBind entity);

        /// <summary>
        /// 删除指定FbGoodsArchivesBind
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbGoodsArchivesBind entity);

        /// <summary>
        /// FbGoodsArchivesBind
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbGoodsArchivesBind> entitys);


        SearchResult<FbGoodsArchivesBind> Search(SearchDtoBase<FbGoodsArchivesBind> c);
		
		IList<FbGoodsArchivesBind> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



