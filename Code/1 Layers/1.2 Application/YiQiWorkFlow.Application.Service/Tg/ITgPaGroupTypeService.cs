/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgPaGroupTypeService
    {
        string Create(TgPaGroupType entity);

        TgPaGroupType GetById(string id);

        IList<TgPaGroupType> GetAll();

        void Update(TgPaGroupType entity);

        /// <summary>
        /// 删除指定TgPaGroupType
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgPaGroupType entity);

        /// <summary>
        /// TgPaGroupType
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgPaGroupType> entitys);


        SearchResult<TgPaGroupType> Search(SearchDtoBase<TgPaGroupType> c);
		
		IList<TgPaGroupType> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



