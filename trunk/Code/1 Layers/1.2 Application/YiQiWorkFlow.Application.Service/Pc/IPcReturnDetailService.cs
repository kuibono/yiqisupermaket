/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public interface IPcReturnDetailService
    {
        string Create(PcReturnDetail entity);

        PcReturnDetail GetById(string id);

        IList<PcReturnDetail> GetAll();

        void Update(PcReturnDetail entity);

        /// <summary>
        /// 删除指定PcReturnDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(PcReturnDetail entity);

        /// <summary>
        /// PcReturnDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<PcReturnDetail> entitys);


        SearchResult<PcReturnDetail> Search(SearchDtoBase<PcReturnDetail> c);
		
		IList<PcReturnDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



