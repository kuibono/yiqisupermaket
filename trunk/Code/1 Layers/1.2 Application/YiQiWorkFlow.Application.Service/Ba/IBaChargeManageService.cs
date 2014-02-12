/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaChargeManageService
    {
        string Create(BaChargeManage entity);

        BaChargeManage GetById(string id);

        IList<BaChargeManage> GetAll();

        void Update(BaChargeManage entity);

        /// <summary>
        /// 删除指定BaChargeManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaChargeManage entity);

        /// <summary>
        /// BaChargeManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaChargeManage> entitys);


        SearchResult<BaChargeManage> Search(SearchDtoBase<BaChargeManage> c);
		
		IList<BaChargeManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



