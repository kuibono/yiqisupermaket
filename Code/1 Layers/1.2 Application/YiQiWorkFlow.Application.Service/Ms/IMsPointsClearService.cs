/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsPointsClearService
    {
        int Create(MsPointsClear entity);

        MsPointsClear GetById(int id);

        IList<MsPointsClear> GetAll();

        void Update(MsPointsClear entity);

        /// <summary>
        /// 删除指定MsPointsClear
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsPointsClear entity);

        /// <summary>
        /// MsPointsClear
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsPointsClear> entitys);


        SearchResult<MsPointsClear> Search(SearchDtoBase<MsPointsClear> c);
		
		IList<MsPointsClear> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



