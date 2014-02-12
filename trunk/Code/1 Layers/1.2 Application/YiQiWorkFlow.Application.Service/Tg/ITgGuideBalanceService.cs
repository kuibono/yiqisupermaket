/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgGuideBalanceService
    {
        string Create(TgGuideBalance entity);

        TgGuideBalance GetById(string id);

        IList<TgGuideBalance> GetAll();

        void Update(TgGuideBalance entity);

        /// <summary>
        /// 删除指定TgGuideBalance
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgGuideBalance entity);

        /// <summary>
        /// TgGuideBalance
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgGuideBalance> entitys);


        SearchResult<TgGuideBalance> Search(SearchDtoBase<TgGuideBalance> c);
		
		IList<TgGuideBalance> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



