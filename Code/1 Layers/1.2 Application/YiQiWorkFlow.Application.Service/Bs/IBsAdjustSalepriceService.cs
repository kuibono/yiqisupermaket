/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsAdjustSalepriceService
    {
        string Create(BsAdjustSaleprice entity);

        BsAdjustSaleprice GetById(string id);

        IList<BsAdjustSaleprice> GetAll();

        void Update(BsAdjustSaleprice entity);

        /// <summary>
        /// 删除指定BsAdjustSaleprice
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsAdjustSaleprice entity);

        /// <summary>
        /// BsAdjustSaleprice
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsAdjustSaleprice> entitys);


        SearchResult<BsAdjustSaleprice> Search(SearchDtoBase<BsAdjustSaleprice> c);
		
		IList<BsAdjustSaleprice> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}


