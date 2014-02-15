/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsReturnManageService
    {
        string Create(BsReturnManage entity);

        BsReturnManage GetById(string id);

        IList<BsReturnManage> GetAll();

        void Update(BsReturnManage entity);

        /// <summary>
        /// 删除指定BsReturnManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsReturnManage entity);

        /// <summary>
        /// BsReturnManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsReturnManage> entitys);


        SearchResult<BsReturnManage> Search(SearchDtoBase<BsReturnManage> c);
		
		IList<BsReturnManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



