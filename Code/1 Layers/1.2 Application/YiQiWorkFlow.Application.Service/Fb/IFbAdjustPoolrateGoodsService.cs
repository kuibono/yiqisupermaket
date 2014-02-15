/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbAdjustPoolrateGoodsService
    {
        string Create(FbAdjustPoolrateGoods entity);

        FbAdjustPoolrateGoods GetById(string id);

        IList<FbAdjustPoolrateGoods> GetAll();

        void Update(FbAdjustPoolrateGoods entity);

        /// <summary>
        /// 删除指定FbAdjustPoolrateGoods
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbAdjustPoolrateGoods entity);

        /// <summary>
        /// FbAdjustPoolrateGoods
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbAdjustPoolrateGoods> entitys);


        SearchResult<FbAdjustPoolrateGoods> Search(SearchDtoBase<FbAdjustPoolrateGoods> c);
		
		IList<FbAdjustPoolrateGoods> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



