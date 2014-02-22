/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public interface IPcPutinManageService
    {
        int Create(PcPutinManage entity);

        PcPutinManage GetById(int id);

        IList<PcPutinManage> GetAll();

        void Update(PcPutinManage entity);

        /// <summary>
        /// 删除指定PcPutinManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(PcPutinManage entity);

        /// <summary>
        /// PcPutinManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<PcPutinManage> entitys);


        SearchResult<PcPutinManage> Search(SearchDtoBase<PcPutinManage> c);
		
		IList<PcPutinManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}


