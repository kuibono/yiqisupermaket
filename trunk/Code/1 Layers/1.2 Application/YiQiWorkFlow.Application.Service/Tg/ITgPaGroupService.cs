/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgPaGroupService
    {
        string Create(TgPaGroup entity);

        TgPaGroup GetById(string id);

        IList<TgPaGroup> GetAll();

        void Update(TgPaGroup entity);

        /// <summary>
        /// 删除指定TgPaGroup
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgPaGroup entity);

        /// <summary>
        /// TgPaGroup
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgPaGroup> entitys);


        SearchResult<TgPaGroup> Search(SearchDtoBase<TgPaGroup> c);
		
		IList<TgPaGroup> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



