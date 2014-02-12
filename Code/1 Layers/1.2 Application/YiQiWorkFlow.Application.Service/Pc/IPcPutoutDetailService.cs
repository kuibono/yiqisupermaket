/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public interface IPcPutoutDetailService
    {
        string Create(PcPutoutDetail entity);

        PcPutoutDetail GetById(string id);

        IList<PcPutoutDetail> GetAll();

        void Update(PcPutoutDetail entity);

        /// <summary>
        /// 删除指定PcPutoutDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(PcPutoutDetail entity);

        /// <summary>
        /// PcPutoutDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<PcPutoutDetail> entitys);


        SearchResult<PcPutoutDetail> Search(SearchDtoBase<PcPutoutDetail> c);
		
		IList<PcPutoutDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



