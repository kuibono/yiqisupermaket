/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsExchangeManageService
    {
        string Create(MsExchangeManage entity);

        MsExchangeManage GetById(string id);

        IList<MsExchangeManage> GetAll();

        void Update(MsExchangeManage entity);

        /// <summary>
        /// 删除指定MsExchangeManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsExchangeManage entity);

        /// <summary>
        /// MsExchangeManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsExchangeManage> entitys);


        SearchResult<MsExchangeManage> Search(SearchDtoBase<MsExchangeManage> c);
		
		IList<MsExchangeManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



