/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtClassPromotionGoodsService
    {
        string Create(RtClassPromotionGoods entity);

        RtClassPromotionGoods GetById(string id);

        IList<RtClassPromotionGoods> GetAll();

        void Update(RtClassPromotionGoods entity);

        /// <summary>
        /// 删除指定RtClassPromotionGoods
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtClassPromotionGoods entity);

        /// <summary>
        /// RtClassPromotionGoods
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtClassPromotionGoods> entitys);


        SearchResult<RtClassPromotionGoods> Search(SearchDtoBase<RtClassPromotionGoods> c);
		
		IList<RtClassPromotionGoods> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



