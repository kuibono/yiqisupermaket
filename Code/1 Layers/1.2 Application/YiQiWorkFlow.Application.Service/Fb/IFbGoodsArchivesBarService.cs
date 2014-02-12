/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbGoodsArchivesBarService
    {
        string Create(FbGoodsArchivesBar entity);

        FbGoodsArchivesBar GetById(string id);

        IList<FbGoodsArchivesBar> GetAll();

        void Update(FbGoodsArchivesBar entity);

        /// <summary>
        /// 删除指定FbGoodsArchivesBar
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbGoodsArchivesBar entity);

        /// <summary>
        /// FbGoodsArchivesBar
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbGoodsArchivesBar> entitys);


        SearchResult<FbGoodsArchivesBar> Search(SearchDtoBase<FbGoodsArchivesBar> c);
		
		IList<FbGoodsArchivesBar> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



