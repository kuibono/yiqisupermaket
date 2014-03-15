﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiQiWorkFlow.Domain.Basement
{
    public class SearchDtoBase<T>
    {
        private int _pageindex = 0;
        public int pageIndex
        {
            get
            {
                if (_pageindex < 0)
                {
                    return 0;
                }
                return _pageindex;
            }
            set
            {
                _pageindex = value;
            }
        }

        private int _pagesize = 100;
        public int pageSize
        {
            get
            {
                if (_pagesize <= 0)
                {
                    return 1;
                }
                return _pagesize;
            }
            set
            {
                _pagesize = value;
            }
        }

        public string sortField { get; set; }

        public string sortOrder { get; set; }

        public string key { get; set; }

        public T entity { get; set; }

        public DateTime? OperatorDateH { get; set; }
        public DateTime? OperatorDateL { get; set; }

        public DateTime? ExamineDateH { get; set; }
        public DateTime? ExamineDateL { get; set; }

        public DateTime? CreateDateH { get; set; }
        public DateTime? CreateDateL { get; set; }

        public DateTime? PutinDateH { get; set; }
        public DateTime? PutinDateL { get; set; }

        public DateTime? CheckDateH { get; set; }
        public DateTime? CheckDateL { get; set; }

        public DateTime? PurchaseDateH { get; set; }
        public DateTime? PurchaseDateL { get; set; }

        public DateTime? RtDateH { get; set; }
        public DateTime? RtDateL { get; set; }
    }

    public class SearchDtoBaseTest
    {
        private int _pageIndex = 1;
        public int pageIndex
        {
            get
            {
                if (_pageIndex <= 0)
                {
                    return 1;
                }
                return _pageIndex;
            }
            set
            {
                _pageIndex = value;
            }
        }

        private int _pagesize = 100;
        public int pageSize
        {
            get
            {
                if (_pagesize <= 0)
                {
                    return 1;
                }
                return _pagesize;
            }
            set
            {
                _pagesize = value;
            }
        }

        public int sortField { get; set; }

        public int sortOrder { get; set; }

    }
}
