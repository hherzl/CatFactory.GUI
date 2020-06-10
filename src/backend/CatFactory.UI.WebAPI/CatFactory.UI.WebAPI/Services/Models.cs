﻿using System.Collections.Generic;
using CatFactory.ObjectRelationalMapping;

namespace CatFactory.UI.WebAPI.Services
{
    public class TableDetail
    {
        public string Schema { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string FullName { get; set; }

        public int ColumnsCount { get; set; }

        public string PrimaryKey { get; set; }

        public string Identity { get; set; }

        public string Details { get; } = "Details";
    }

    public class ViewDetail
    {
        public string Schema { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string FullName { get; set; }

        public int ColumnsCount { get; set; }

        public string Identity { get; set; }

        public string Details { get; } = "Details";
    }

    public class DatabaseDetail
    {
        public string Name { get; set; }

        public IEnumerable<TableDetail> Tables { get; set; }

        public IEnumerable<ViewDetail> Views { get; set; }

        public IEnumerable<DatabaseTypeMap> DatabaseTypeMaps { get; set; }
    }
}
