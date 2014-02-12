/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPaSalesetService
    {
        string Create(RtPaSaleset entity);

        RtPaSaleset GetById(string id);

        IList<RtPaSaleset> GetAll();

        void Update(RtPaSaleset entity);

        /// <summary>
        /// 删除指定RtPaSaleset
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPaSaleset entity);

        /// <summary>
        /// RtPaSaleset
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPaSaleset> entitys);


        SearchResult<RtPaSaleset> Search(SearchDtoBase<RtPaSaleset> c);
		
		IList<RtPaSaleset> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



