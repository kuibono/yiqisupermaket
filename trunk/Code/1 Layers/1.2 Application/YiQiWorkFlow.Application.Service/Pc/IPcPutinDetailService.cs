/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public interface IPcPutinDetailService
    {
        string Create(PcPutinDetail entity);

        PcPutinDetail GetById(string id);

        IList<PcPutinDetail> GetAll();

        void Update(PcPutinDetail entity);

        /// <summary>
        /// 删除指定PcPutinDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(PcPutinDetail entity);

        /// <summary>
        /// PcPutinDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<PcPutinDetail> entitys);


        SearchResult<PcPutinDetail> Search(SearchDtoBase<PcPutinDetail> c);
		
		IList<PcPutinDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



