/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgGroupBalanceService
    {
        string Create(TgGroupBalance entity);

        TgGroupBalance GetById(string id);

        IList<TgGroupBalance> GetAll();

        void Update(TgGroupBalance entity);

        /// <summary>
        /// 删除指定TgGroupBalance
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgGroupBalance entity);

        /// <summary>
        /// TgGroupBalance
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgGroupBalance> entitys);


        SearchResult<TgGroupBalance> Search(SearchDtoBase<TgGroupBalance> c);
		
		IList<TgGroupBalance> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



