/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpSplitComManageService
    {
        string Create(OpSplitComManage entity);

        OpSplitComManage GetById(string id);

        IList<OpSplitComManage> GetAll();

        void Update(OpSplitComManage entity);

        /// <summary>
        /// 删除指定OpSplitComManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpSplitComManage entity);

        /// <summary>
        /// OpSplitComManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpSplitComManage> entitys);


        SearchResult<OpSplitComManage> Search(SearchDtoBase<OpSplitComManage> c);
		
		IList<OpSplitComManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



