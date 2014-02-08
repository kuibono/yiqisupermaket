using System.Collections.Generic;
using YiQiWorkFlow.Domain.Archives;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Archives
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