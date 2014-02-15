/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbPaGoodsCounterService
    {
        string Create(FbPaGoodsCounter entity);

        FbPaGoodsCounter GetById(string id);

        IList<FbPaGoodsCounter> GetAll();

        void Update(FbPaGoodsCounter entity);

        /// <summary>
        /// 删除指定FbPaGoodsCounter
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbPaGoodsCounter entity);

        /// <summary>
        /// FbPaGoodsCounter
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbPaGoodsCounter> entitys);


        SearchResult<FbPaGoodsCounter> Search(SearchDtoBase<FbPaGoodsCounter> c);
		
		IList<FbPaGoodsCounter> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



