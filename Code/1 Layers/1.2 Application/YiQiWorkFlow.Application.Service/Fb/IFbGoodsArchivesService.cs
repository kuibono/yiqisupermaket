/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbGoodsArchivesService
    {
        string Create(FbGoodsArchives entity);

        FbGoodsArchives GetById(string id);

        IList<FbGoodsArchives> GetAll();

        void Update(FbGoodsArchives entity);

        /// <summary>
        /// 删除指定FbGoodsArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbGoodsArchives entity);

        /// <summary>
        /// FbGoodsArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbGoodsArchives> entitys);


        SearchResult<FbGoodsArchives> Search(SearchDtoBase<FbGoodsArchives> c);
		
		IList<FbGoodsArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



