/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public interface IPcPurchaseDetailService
    {
        string Create(PcPurchaseDetail entity);

        PcPurchaseDetail GetById(string id);

        IList<PcPurchaseDetail> GetByPcNumber(string pcNnumber);

        IList<PcPurchaseDetail> GetByPcNumbers(IList<string> pcNnumbers);

        IList<PcPurchaseDetail> GetAll();

        void Update(PcPurchaseDetail entity);

        /// <summary>
        /// 删除指定PcPurchaseDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(PcPurchaseDetail entity);

        /// <summary>
        /// PcPurchaseDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<PcPurchaseDetail> entitys);


        SearchResult<PcPurchaseDetail> Search(SearchDtoBase<PcPurchaseDetail> c);
		
		IList<PcPurchaseDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



