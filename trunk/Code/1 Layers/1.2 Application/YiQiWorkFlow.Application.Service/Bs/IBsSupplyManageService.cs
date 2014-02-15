/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsSupplyManageService
    {
        string Create(BsSupplyManage entity);

        BsSupplyManage GetById(string id);

        IList<BsSupplyManage> GetAll();

        void Update(BsSupplyManage entity);

        /// <summary>
        /// 删除指定BsSupplyManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsSupplyManage entity);

        /// <summary>
        /// BsSupplyManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsSupplyManage> entitys);


        SearchResult<BsSupplyManage> Search(SearchDtoBase<BsSupplyManage> c);
		
		IList<BsSupplyManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



