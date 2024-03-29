/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsBranchAllotDetailService
    {
        string Create(BsBranchAllotDetail entity);

        BsBranchAllotDetail GetById(string id);

        IList<BsBranchAllotDetail> GetAll();

        void Update(BsBranchAllotDetail entity);

        /// <summary>
        /// 删除指定BsBranchAllotDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsBranchAllotDetail entity);

        /// <summary>
        /// BsBranchAllotDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsBranchAllotDetail> entitys);


        SearchResult<BsBranchAllotDetail> Search(SearchDtoBase<BsBranchAllotDetail> c);
		
		IList<BsBranchAllotDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



