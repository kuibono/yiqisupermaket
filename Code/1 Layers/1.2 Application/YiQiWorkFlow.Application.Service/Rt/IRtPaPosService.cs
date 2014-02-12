/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPaPosService
    {
        string Create(RtPaPos entity);

        RtPaPos GetById(string id);

        IList<RtPaPos> GetAll();

        void Update(RtPaPos entity);

        /// <summary>
        /// 删除指定RtPaPos
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPaPos entity);

        /// <summary>
        /// RtPaPos
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPaPos> entitys);


        SearchResult<RtPaPos> Search(SearchDtoBase<RtPaPos> c);
		
		IList<RtPaPos> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



