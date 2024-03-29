/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpLossDetailService
    {
        string Create(OpLossDetail entity);

        OpLossDetail GetById(string id);

        IList<OpLossDetail> GetAll();

        void Update(OpLossDetail entity);

        /// <summary>
        /// 删除指定OpLossDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpLossDetail entity);

        /// <summary>
        /// OpLossDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpLossDetail> entitys);


        SearchResult<OpLossDetail> Search(SearchDtoBase<OpLossDetail> c);
		
		IList<OpLossDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



