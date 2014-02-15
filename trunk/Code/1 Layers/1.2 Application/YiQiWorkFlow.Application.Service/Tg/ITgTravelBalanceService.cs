/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgTravelBalanceService
    {
        string Create(TgTravelBalance entity);

        TgTravelBalance GetById(string id);

        IList<TgTravelBalance> GetAll();

        void Update(TgTravelBalance entity);

        /// <summary>
        /// 删除指定TgTravelBalance
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgTravelBalance entity);

        /// <summary>
        /// TgTravelBalance
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgTravelBalance> entitys);


        SearchResult<TgTravelBalance> Search(SearchDtoBase<TgTravelBalance> c);
		
		IList<TgTravelBalance> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



