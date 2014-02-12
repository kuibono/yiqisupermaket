/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpAdjustPurchaseManageService
    {
        string Create(OpAdjustPurchaseManage entity);

        OpAdjustPurchaseManage GetById(string id);

        IList<OpAdjustPurchaseManage> GetAll();

        void Update(OpAdjustPurchaseManage entity);

        /// <summary>
        /// 删除指定OpAdjustPurchaseManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpAdjustPurchaseManage entity);

        /// <summary>
        /// OpAdjustPurchaseManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpAdjustPurchaseManage> entitys);


        SearchResult<OpAdjustPurchaseManage> Search(SearchDtoBase<OpAdjustPurchaseManage> c);
		
		IList<OpAdjustPurchaseManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



