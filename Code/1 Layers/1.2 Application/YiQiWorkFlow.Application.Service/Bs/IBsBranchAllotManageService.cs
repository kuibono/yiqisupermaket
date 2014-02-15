/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsBranchAllotManageService
    {
        string Create(BsBranchAllotManage entity);

        BsBranchAllotManage GetById(string id);

        IList<BsBranchAllotManage> GetAll();

        void Update(BsBranchAllotManage entity);

        /// <summary>
        /// 删除指定BsBranchAllotManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsBranchAllotManage entity);

        /// <summary>
        /// BsBranchAllotManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsBranchAllotManage> entitys);


        SearchResult<BsBranchAllotManage> Search(SearchDtoBase<BsBranchAllotManage> c);
		
		IList<BsBranchAllotManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



