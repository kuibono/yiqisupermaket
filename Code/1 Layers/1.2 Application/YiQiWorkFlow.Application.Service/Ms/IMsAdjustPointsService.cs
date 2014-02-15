/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsAdjustPointsService
    {
        int Create(MsAdjustPoints entity);

        MsAdjustPoints GetById(int id);

        IList<MsAdjustPoints> GetAll();

        void Update(MsAdjustPoints entity);

        /// <summary>
        /// 删除指定MsAdjustPoints
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsAdjustPoints entity);

        /// <summary>
        /// MsAdjustPoints
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsAdjustPoints> entitys);


        SearchResult<MsAdjustPoints> Search(SearchDtoBase<MsAdjustPoints> c);
		
		IList<MsAdjustPoints> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



