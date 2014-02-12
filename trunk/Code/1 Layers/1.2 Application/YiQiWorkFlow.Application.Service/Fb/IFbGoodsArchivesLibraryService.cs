/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbGoodsArchivesLibraryService
    {
        string Create(FbGoodsArchivesLibrary entity);

        FbGoodsArchivesLibrary GetById(string id);

        IList<FbGoodsArchivesLibrary> GetAll();

        void Update(FbGoodsArchivesLibrary entity);

        /// <summary>
        /// 删除指定FbGoodsArchivesLibrary
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbGoodsArchivesLibrary entity);

        /// <summary>
        /// FbGoodsArchivesLibrary
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbGoodsArchivesLibrary> entitys);


        SearchResult<FbGoodsArchivesLibrary> Search(SearchDtoBase<FbGoodsArchivesLibrary> c);
		
		IList<FbGoodsArchivesLibrary> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



