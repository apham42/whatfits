﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using server.Model.Search;
using Whatfits.Models.Models;

namespace server.Model.Data_Transfer_Objects.SearchDTO_s
{
    public class SearchResponseDTO
    {
        public List<string> Messages { get; set; }
        public bool IsSuccessful { get; set; }
        public List<SearchResult> SearchResults { get; set; }
        public List<GeoCoordinates> GeoList { get; set; }
    }
}