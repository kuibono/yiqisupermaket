/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaPoolDetailService
    {
        string Create(BaPoolDetail entity);

        BaPoolDetail GetById(string id);

        IList<BaPoolDetail> GetAll();

        void Update(BaPoolDetail entity);

        /// <summary>
        /// 删除指定BaPoolDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaPoolDetail entity);

        /// <summary>
        /// BaPoolDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaPoolDetail> entitys);


        SearchResult<BaPoolDetail> Search(SearchDtoBase<BaPoolDetail> c);
		
		IList<BaPoolDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



