/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsReclaimCardManageService
    {
        string Create(MsReclaimCardManage entity);

        MsReclaimCardManage GetById(string id);

        IList<MsReclaimCardManage> GetAll();

        void Update(MsReclaimCardManage entity);

        /// <summary>
        /// 删除指定MsReclaimCardManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsReclaimCardManage entity);

        /// <summary>
        /// MsReclaimCardManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsReclaimCardManage> entitys);


        SearchResult<MsReclaimCardManage> Search(SearchDtoBase<MsReclaimCardManage> c);
		
		IList<MsReclaimCardManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);

        string GenerateReclaimNumber();
    }
}



