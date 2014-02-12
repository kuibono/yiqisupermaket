/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpAllotDetailService
    {
        string Create(OpAllotDetail entity);

        OpAllotDetail GetById(string id);

        IList<OpAllotDetail> GetAll();

        void Update(OpAllotDetail entity);

        /// <summary>
        /// 删除指定OpAllotDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpAllotDetail entity);

        /// <summary>
        /// OpAllotDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpAllotDetail> entitys);


        SearchResult<OpAllotDetail> Search(SearchDtoBase<OpAllotDetail> c);
		
		IList<OpAllotDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



