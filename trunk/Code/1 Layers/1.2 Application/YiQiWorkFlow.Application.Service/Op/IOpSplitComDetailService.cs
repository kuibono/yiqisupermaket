/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpSplitComDetailService
    {
        string Create(OpSplitComDetail entity);

        OpSplitComDetail GetById(string id);

        IList<OpSplitComDetail> GetAll();

        void Update(OpSplitComDetail entity);

        /// <summary>
        /// 删除指定OpSplitComDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpSplitComDetail entity);

        /// <summary>
        /// OpSplitComDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpSplitComDetail> entitys);


        SearchResult<OpSplitComDetail> Search(SearchDtoBase<OpSplitComDetail> c);
		
		IList<OpSplitComDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



