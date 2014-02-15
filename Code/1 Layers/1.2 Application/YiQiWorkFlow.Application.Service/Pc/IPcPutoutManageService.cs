/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public interface IPcPutoutManageService
    {
        int Create(PcPutoutManage entity);

        PcPutoutManage GetById(int id);

        IList<PcPutoutManage> GetAll();

        void Update(PcPutoutManage entity);

        /// <summary>
        /// 删除指定PcPutoutManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(PcPutoutManage entity);

        /// <summary>
        /// PcPutoutManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<PcPutoutManage> entitys);


        SearchResult<PcPutoutManage> Search(SearchDtoBase<PcPutoutManage> c);
		
		IList<PcPutoutManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



