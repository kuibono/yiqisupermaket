/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpSplitComGoodsService
    {
        string Create(OpSplitComGoods entity);

        OpSplitComGoods GetById(string id);

        IList<OpSplitComGoods> GetAll();

        void Update(OpSplitComGoods entity);

        /// <summary>
        /// 删除指定OpSplitComGoods
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpSplitComGoods entity);

        /// <summary>
        /// OpSplitComGoods
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpSplitComGoods> entitys);


        SearchResult<OpSplitComGoods> Search(SearchDtoBase<OpSplitComGoods> c);
		
		IList<OpSplitComGoods> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



