﻿using Winner.Feature.People.Models;
using System.Collections.Generic;

namespace Winner.Feature.People.Facets
{
    public interface IFacetBuilder
    {
        public IDictionary<string, List<Facet>> CalculateFacets(IList<MvpSearchResult> mvps, SearchParams searchParams);
    }
}
