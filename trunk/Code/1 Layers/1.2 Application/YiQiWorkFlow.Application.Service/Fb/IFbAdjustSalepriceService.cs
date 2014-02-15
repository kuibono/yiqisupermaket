/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbAdjustSalepriceService
    {
        string Create(FbAdjustSaleprice entity);

        FbAdjustSaleprice GetById(string id);

        IList<FbAdjustSaleprice> GetAll();

        void Update(FbAdjustSaleprice entity);

        /// <summary>
        /// 删除指定FbAdjustSaleprice
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbAdjustSaleprice entity);

        /// <summary>
        /// FbAdjustSaleprice
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbAdjustSaleprice> entitys);


        SearchResult<FbAdjustSaleprice> Search(SearchDtoBase<FbAdjustSaleprice> c);
		
		IList<FbAdjustSaleprice> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



