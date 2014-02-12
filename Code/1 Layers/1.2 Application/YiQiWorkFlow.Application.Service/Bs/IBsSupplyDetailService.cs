/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsSupplyDetailService
    {
        string Create(BsSupplyDetail entity);

        BsSupplyDetail GetById(string id);

        IList<BsSupplyDetail> GetAll();

        void Update(BsSupplyDetail entity);

        /// <summary>
        /// 删除指定BsSupplyDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsSupplyDetail entity);

        /// <summary>
        /// BsSupplyDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsSupplyDetail> entitys);


        SearchResult<BsSupplyDetail> Search(SearchDtoBase<BsSupplyDetail> c);
		
		IList<BsSupplyDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



