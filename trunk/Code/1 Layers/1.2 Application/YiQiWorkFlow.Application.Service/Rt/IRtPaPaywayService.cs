/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPaPaywayService
    {
        string Create(RtPaPayway entity);

        RtPaPayway GetById(string id);

        IList<RtPaPayway> GetAll();

        void Update(RtPaPayway entity);

        /// <summary>
        /// 删除指定RtPaPayway
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPaPayway entity);

        /// <summary>
        /// RtPaPayway
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPaPayway> entitys);


        SearchResult<RtPaPayway> Search(SearchDtoBase<RtPaPayway> c);
		
		IList<RtPaPayway> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



