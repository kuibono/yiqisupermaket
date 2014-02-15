/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPaShiftService
    {
        string Create(RtPaShift entity);

        RtPaShift GetById(string id);

        IList<RtPaShift> GetAll();

        void Update(RtPaShift entity);

        /// <summary>
        /// 删除指定RtPaShift
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPaShift entity);

        /// <summary>
        /// RtPaShift
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPaShift> entitys);


        SearchResult<RtPaShift> Search(SearchDtoBase<RtPaShift> c);
		
		IList<RtPaShift> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



