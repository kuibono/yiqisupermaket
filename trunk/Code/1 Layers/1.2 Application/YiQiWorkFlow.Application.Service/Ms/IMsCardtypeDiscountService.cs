/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsCardtypeDiscountService
    {
        string Create(MsCardtypeDiscount entity);

        MsCardtypeDiscount GetById(string id);

        IList<MsCardtypeDiscount> GetAll();

        void Update(MsCardtypeDiscount entity);

        /// <summary>
        /// 删除指定MsCardtypeDiscount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsCardtypeDiscount entity);

        /// <summary>
        /// MsCardtypeDiscount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsCardtypeDiscount> entitys);


        SearchResult<MsCardtypeDiscount> Search(SearchDtoBase<MsCardtypeDiscount> c);
		
		IList<MsCardtypeDiscount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



