/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgGuideBalanceDetailService
    {
        string Create(TgGuideBalanceDetail entity);

        TgGuideBalanceDetail GetById(string id);

        IList<TgGuideBalanceDetail> GetAll();

        void Update(TgGuideBalanceDetail entity);

        /// <summary>
        /// 删除指定TgGuideBalanceDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgGuideBalanceDetail entity);

        /// <summary>
        /// TgGuideBalanceDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgGuideBalanceDetail> entitys);


        SearchResult<TgGuideBalanceDetail> Search(SearchDtoBase<TgGuideBalanceDetail> c);
		
		IList<TgGuideBalanceDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



