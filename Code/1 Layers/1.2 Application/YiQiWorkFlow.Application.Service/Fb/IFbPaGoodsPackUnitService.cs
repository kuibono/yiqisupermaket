/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbPaGoodsPackUnitService
    {
        string Create(FbPaGoodsPackUnit entity);

        FbPaGoodsPackUnit GetById(string id);

        IList<FbPaGoodsPackUnit> GetAll();

        void Update(FbPaGoodsPackUnit entity);

        /// <summary>
        /// 删除指定FbPaGoodsPackUnit
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbPaGoodsPackUnit entity);

        /// <summary>
        /// FbPaGoodsPackUnit
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbPaGoodsPackUnit> entitys);


        SearchResult<FbPaGoodsPackUnit> Search(SearchDtoBase<FbPaGoodsPackUnit> c);
		
		IList<FbPaGoodsPackUnit> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



