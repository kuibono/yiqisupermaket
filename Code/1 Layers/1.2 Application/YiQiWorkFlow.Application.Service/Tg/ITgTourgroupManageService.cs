/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgTourgroupManageService
    {
        int Create(TgTourgroupManage entity);

        TgTourgroupManage GetById(int id);

        IList<TgTourgroupManage> GetAll();

        void Update(TgTourgroupManage entity);

        /// <summary>
        /// 删除指定TgTourgroupManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgTourgroupManage entity);

        /// <summary>
        /// TgTourgroupManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgTourgroupManage> entitys);


        SearchResult<TgTourgroupManage> Search(SearchDtoBase<TgTourgroupManage> c);
		
		IList<TgTourgroupManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



