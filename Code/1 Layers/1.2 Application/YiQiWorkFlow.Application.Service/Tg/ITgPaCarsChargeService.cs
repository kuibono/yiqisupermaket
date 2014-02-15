/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgPaCarsChargeService
    {
        string Create(TgPaCarsCharge entity);

        TgPaCarsCharge GetById(string id);

        IList<TgPaCarsCharge> GetAll();

        void Update(TgPaCarsCharge entity);

        /// <summary>
        /// 删除指定TgPaCarsCharge
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgPaCarsCharge entity);

        /// <summary>
        /// TgPaCarsCharge
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgPaCarsCharge> entitys);


        SearchResult<TgPaCarsCharge> Search(SearchDtoBase<TgPaCarsCharge> c);
		
		IList<TgPaCarsCharge> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



