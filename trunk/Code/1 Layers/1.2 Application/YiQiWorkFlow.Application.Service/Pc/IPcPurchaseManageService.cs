/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public interface IPcPurchaseManageService
    {
        string Create(PcPurchaseManage entity);

        PcPurchaseManage GetById(string id);

        IList<PcPurchaseManage> GetAll();

        void Update(PcPurchaseManage entity);

        /// <summary>
        /// 删除指定PcPurchaseManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(PcPurchaseManage entity);

        /// <summary>
        /// PcPurchaseManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<PcPurchaseManage> entitys);


        SearchResult<PcPurchaseManage> Search(SearchDtoBase<PcPurchaseManage> c);
		
		IList<PcPurchaseManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



