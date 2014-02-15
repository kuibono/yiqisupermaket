/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpAdjustPurchaseDetailService
    {
        string Create(OpAdjustPurchaseDetail entity);

        OpAdjustPurchaseDetail GetById(string id);

        IList<OpAdjustPurchaseDetail> GetAll();

        void Update(OpAdjustPurchaseDetail entity);

        /// <summary>
        /// 删除指定OpAdjustPurchaseDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpAdjustPurchaseDetail entity);

        /// <summary>
        /// OpAdjustPurchaseDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpAdjustPurchaseDetail> entitys);


        SearchResult<OpAdjustPurchaseDetail> Search(SearchDtoBase<OpAdjustPurchaseDetail> c);
		
		IList<OpAdjustPurchaseDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



