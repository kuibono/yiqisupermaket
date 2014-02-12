/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsBranchArchivesService
    {
        string Create(BsBranchArchives entity);

        BsBranchArchives GetById(string id);

        IList<BsBranchArchives> GetAll();

        void Update(BsBranchArchives entity);

        /// <summary>
        /// 删除指定BsBranchArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsBranchArchives entity);

        /// <summary>
        /// BsBranchArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsBranchArchives> entitys);


        SearchResult<BsBranchArchives> Search(SearchDtoBase<BsBranchArchives> c);
		
		IList<BsBranchArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



