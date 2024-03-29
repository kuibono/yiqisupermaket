/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgGroupBalanceDetailService
    {
        string Create(TgGroupBalanceDetail entity);

        TgGroupBalanceDetail GetById(string id);

        IList<TgGroupBalanceDetail> GetAll();

        void Update(TgGroupBalanceDetail entity);

        /// <summary>
        /// 删除指定TgGroupBalanceDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgGroupBalanceDetail entity);

        /// <summary>
        /// TgGroupBalanceDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgGroupBalanceDetail> entitys);


        SearchResult<TgGroupBalanceDetail> Search(SearchDtoBase<TgGroupBalanceDetail> c);
		
		IList<TgGroupBalanceDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



