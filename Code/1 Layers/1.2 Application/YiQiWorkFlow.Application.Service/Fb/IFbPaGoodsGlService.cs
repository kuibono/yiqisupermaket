/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbPaGoodsGlService
    {
        string Create(FbPaGoodsGl entity);

        FbPaGoodsGl GetById(string id);

        IList<FbPaGoodsGl> GetAll();

        void Update(FbPaGoodsGl entity);

        /// <summary>
        /// 删除指定FbPaGoodsGl
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbPaGoodsGl entity);

        /// <summary>
        /// FbPaGoodsGl
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbPaGoodsGl> entitys);


        SearchResult<FbPaGoodsGl> Search(SearchDtoBase<FbPaGoodsGl> c);
		
		IList<FbPaGoodsGl> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



