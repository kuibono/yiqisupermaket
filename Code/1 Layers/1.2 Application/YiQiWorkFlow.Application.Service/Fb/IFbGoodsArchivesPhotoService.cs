/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbGoodsArchivesPhotoService
    {
        string Create(FbGoodsArchivesPhoto entity);

        FbGoodsArchivesPhoto GetById(string id);

        IList<FbGoodsArchivesPhoto> GetAll();

        void Update(FbGoodsArchivesPhoto entity);

        /// <summary>
        /// 删除指定FbGoodsArchivesPhoto
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbGoodsArchivesPhoto entity);

        /// <summary>
        /// FbGoodsArchivesPhoto
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbGoodsArchivesPhoto> entitys);


        SearchResult<FbGoodsArchivesPhoto> Search(SearchDtoBase<FbGoodsArchivesPhoto> c);
		
		IList<FbGoodsArchivesPhoto> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



