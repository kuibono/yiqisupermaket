/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPresentPromotionGoodsService
    {
        string Create(RtPresentPromotionGoods entity);

        RtPresentPromotionGoods GetById(string id);

        IList<RtPresentPromotionGoods> GetAll();

        void Update(RtPresentPromotionGoods entity);

        /// <summary>
        /// 删除指定RtPresentPromotionGoods
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPresentPromotionGoods entity);

        /// <summary>
        /// RtPresentPromotionGoods
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPresentPromotionGoods> entitys);


        SearchResult<RtPresentPromotionGoods> Search(SearchDtoBase<RtPresentPromotionGoods> c);
		
		IList<RtPresentPromotionGoods> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



