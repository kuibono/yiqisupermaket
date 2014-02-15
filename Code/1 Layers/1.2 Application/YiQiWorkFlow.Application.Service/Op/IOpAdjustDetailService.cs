/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpAdjustDetailService
    {
        string Create(OpAdjustDetail entity);

        OpAdjustDetail GetById(string id);

        IList<OpAdjustDetail> GetAll();

        void Update(OpAdjustDetail entity);

        /// <summary>
        /// 删除指定OpAdjustDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpAdjustDetail entity);

        /// <summary>
        /// OpAdjustDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpAdjustDetail> entitys);


        SearchResult<OpAdjustDetail> Search(SearchDtoBase<OpAdjustDetail> c);
		
		IList<OpAdjustDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



