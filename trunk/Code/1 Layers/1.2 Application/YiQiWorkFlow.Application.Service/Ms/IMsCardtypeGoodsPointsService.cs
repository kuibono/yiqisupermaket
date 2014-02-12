/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsCardtypeGoodsPointsService
    {
        string Create(MsCardtypeGoodsPoints entity);

        MsCardtypeGoodsPoints GetById(string id);

        IList<MsCardtypeGoodsPoints> GetAll();

        void Update(MsCardtypeGoodsPoints entity);

        /// <summary>
        /// 删除指定MsCardtypeGoodsPoints
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsCardtypeGoodsPoints entity);

        /// <summary>
        /// MsCardtypeGoodsPoints
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsCardtypeGoodsPoints> entitys);


        SearchResult<MsCardtypeGoodsPoints> Search(SearchDtoBase<MsCardtypeGoodsPoints> c);
		
		IList<MsCardtypeGoodsPoints> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



