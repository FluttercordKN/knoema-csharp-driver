﻿using System.Collections.Generic;

namespace Knoema.Search.TimeseriesSearch
{
	public class TimeseriesSearchFacets
	{
		public TimeseriesSearchDataSourceInfos DataSourceInfos { get; set; }
		public Dictionary<string, int> DataSources { get; set; }
		public int Forecasts { get; set; }
		public Dictionary<string, int> Frequencies { get; set; }
		public Dictionary<string, int> LastUpdates { get; set; }
		public int LongTimeseries { get; set; }
		public TimeseriesSearchRegionLinkInfos RegionLinkInfos { get; set; }
		public Dictionary<string, int> RegionLinks { get; set; }
	}
}