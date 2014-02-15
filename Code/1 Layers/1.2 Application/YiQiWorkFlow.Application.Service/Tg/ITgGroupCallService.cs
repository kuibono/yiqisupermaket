/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgGroupCallService
    {
        int Create(TgGroupCall entity);

        TgGroupCall GetById(int id);

        IList<TgGroupCall> GetAll();

        void Update(TgGroupCall entity);

        /// <summary>
        /// 删除指定TgGroupCall
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgGroupCall entity);

        /// <summary>
        /// TgGroupCall
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgGroupCall> entitys);


        SearchResult<TgGroupCall> Search(SearchDtoBase<TgGroupCall> c);
		
		IList<TgGroupCall> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



