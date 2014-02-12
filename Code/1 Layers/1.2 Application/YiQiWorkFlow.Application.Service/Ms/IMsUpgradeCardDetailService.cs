/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsUpgradeCardDetailService
    {
        string Create(MsUpgradeCardDetail entity);

        MsUpgradeCardDetail GetById(string id);

        IList<MsUpgradeCardDetail> GetAll();

        void Update(MsUpgradeCardDetail entity);

        /// <summary>
        /// 删除指定MsUpgradeCardDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsUpgradeCardDetail entity);

        /// <summary>
        /// MsUpgradeCardDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsUpgradeCardDetail> entitys);


        SearchResult<MsUpgradeCardDetail> Search(SearchDtoBase<MsUpgradeCardDetail> c);
		
		IList<MsUpgradeCardDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



