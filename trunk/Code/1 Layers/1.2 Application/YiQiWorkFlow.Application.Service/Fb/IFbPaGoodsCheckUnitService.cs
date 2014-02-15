/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbPaGoodsCheckUnitService
    {
        string Create(FbPaGoodsCheckUnit entity);

        FbPaGoodsCheckUnit GetById(string id);

        IList<FbPaGoodsCheckUnit> GetAll();

        void Update(FbPaGoodsCheckUnit entity);

        /// <summary>
        /// 删除指定FbPaGoodsCheckUnit
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbPaGoodsCheckUnit entity);

        /// <summary>
        /// FbPaGoodsCheckUnit
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbPaGoodsCheckUnit> entitys);


        SearchResult<FbPaGoodsCheckUnit> Search(SearchDtoBase<FbPaGoodsCheckUnit> c);
		
		IList<FbPaGoodsCheckUnit> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



