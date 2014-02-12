/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgPaTaTypeService
    {
        string Create(TgPaTaType entity);

        TgPaTaType GetById(string id);

        IList<TgPaTaType> GetAll();

        void Update(TgPaTaType entity);

        /// <summary>
        /// 删除指定TgPaTaType
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgPaTaType entity);

        /// <summary>
        /// TgPaTaType
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgPaTaType> entitys);


        SearchResult<TgPaTaType> Search(SearchDtoBase<TgPaTaType> c);
		
		IList<TgPaTaType> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



