using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public class FilterService : IFilterService
    {
        public Show[] FilterShows(Request request)
        {
            if(request == null || request.payload == null)
            {
                return null;
            }

            var shows = request.payload.Where(p => p.drm && p.episodeCount > 0)
                .Select(p => new Show { image = p.image.showImage, slug = p.slug, title = p.title });
            return shows.ToArray();
        }
    }
}
