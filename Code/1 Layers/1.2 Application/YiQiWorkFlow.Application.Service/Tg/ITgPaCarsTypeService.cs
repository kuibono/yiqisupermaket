/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgPaCarsTypeService
    {
        string Create(TgPaCarsType entity);

        TgPaCarsType GetById(string id);

        IList<TgPaCarsType> GetAll();

        void Update(TgPaCarsType entity);

        /// <summary>
        /// 删除指定TgPaCarsType
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgPaCarsType entity);

        /// <summary>
        /// TgPaCarsType
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgPaCarsType> entitys);


        SearchResult<TgPaCarsType> Search(SearchDtoBase<TgPaCarsType> c);
		
		IList<TgPaCarsType> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



