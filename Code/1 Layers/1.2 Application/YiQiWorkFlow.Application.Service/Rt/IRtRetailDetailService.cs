/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtRetailDetailService
    {
        int Create(RtRetailDetail entity);

        RtRetailDetail GetById(int id);

        IList<RtRetailDetail> GetAll();

        void Update(RtRetailDetail entity);

        /// <summary>
        /// 删除指定RtRetailDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtRetailDetail entity);

        /// <summary>
        /// RtRetailDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtRetailDetail> entitys);


        SearchResult<RtRetailDetail> Search(SearchDtoBase<RtRetailDetail> c);
		
		IList<RtRetailDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



