/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public interface IPcReturnManageService
    {
        string Create(PcReturnManage entity);

        PcReturnManage GetById(string id);

        IList<PcReturnManage> GetAll();

        void Update(PcReturnManage entity);

        /// <summary>
        /// 删除指定PcReturnManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(PcReturnManage entity);

        /// <summary>
        /// PcReturnManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<PcReturnManage> entitys);


        SearchResult<PcReturnManage> Search(SearchDtoBase<PcReturnManage> c);
		
		IList<PcReturnManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



