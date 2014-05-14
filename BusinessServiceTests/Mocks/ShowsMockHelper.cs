using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceTests.Mocks
{
    public static class ShowsMockHelper
    {
        static Show[] GetMockedShows()
        {
            var shows = new List<Show>();
            shows.Add(new Show { image = "http://catchup.ninemsn.com.au/img/jump-in/shows/16KidsandCounting1280.jpg", slug = "show/16kidsandcounting", title = "16 Kids and Counting" });
            shows.Add(new Show { image = "http://catchup.ninemsn.com.au/img/jump-in/shows/TheTaste1280.jpg", slug = "show/thetaste", title = "The Taste" });
            shows.Add(new Show { image = "http://catchup.ninemsn.com.au/img/jump-in/shows/Thunderbirds_1280.jpg", slug = "show/thunderbirds", title = "Thunderbirds" });
            shows.Add(new Show { image = "http://catchup.ninemsn.com.au/img/jump-in/shows/ScoobyDoo1280.jpg", slug = "show/scoobydoomysteryincorporated", title = "Scooby-Doo! Mystery Incorporated" });
            shows.Add(new Show { image = "http://catchup.ninemsn.com.au/img/jump-in/shows/ToyHunter1280.jpg", slug = "show/toyhunter", title = "Toy Hunter" });
            shows.Add(new Show { image = "http://catchup.ninemsn.com.au/img/jump-in/shows/Worlds1280.jpg", slug = "show/worlds", title = "World's..." });
            shows.Add(new Show { image = "http://catchup.ninemsn.com.au/img/jump-in/shows/TheOriginals1280.jpg", slug = "show/theoriginals", title = "The Originals" });

            return shows.ToArray();
        }

        static Request GetMockedRequest()
        {
            var request = new Request();
            var payload = new List<Payload>();
            payload.Add(new Payload
            {
                country = "UK",
                description = "What's life like when you have enough children to field your own football team?",
                drm = true,
                episodeCount = 3,
                image = new Image
                {
                    showImage = "http://catchup.ninemsn.com.au/img/jump-in/shows/16KidsandCounting1280.jpg"
                },
                language = "English",
                nextEpisode = null,
                primaryColor = "#ff7800",
                seasons = new[] { new Season { slug = "show/16kidsandcounting/season/1" } },
                slug = "show/16kidsandcounting",
                title = "16 Kids and Counting",
                tvChannel = "GEM"
            });

            payload.Add(new Payload
            {
                country = "UK",
                description = "What's life like when you have enough children to field your own football team?",
                drm = false,
                episodeCount = 3,
                image = new Image
                {
                    showImage = "http://catchup.ninemsn.com.au/img/jump-in/shows/16KidsandCounting1280.jpg"
                },
                language = "English",
                nextEpisode = null,
                primaryColor = "#ff7800",
                seasons = new[] { new Season { slug = "show/16kidsandcounting/season/1" } },
                slug = "show/16kidsandcounting",
                title = "16 Kids and Counting",
                tvChannel = "GEM"
            });

            payload.Add(new Payload
            {
                slug = "show/seapatrol",
                title = "Sea Patrol",
                tvChannel = "Channel 9"
            });

            payload.Add(new Payload
            {
                country = "USA",
                description = "The Taste puts 16 culinary competitors in the kitchen, where four of the World's most notable culinary masters of the food world judges their creations based on a blind taste. Join judges Anthony Bourdain, Nigella Lawson, Ludovic Lefebvre and Brian Malarkey in this pressure-packed contest where a single spoonful can catapult a contender to the top or send them packing.",
                drm = true,
                episodeCount = 3,
                image = new Image
                {
                    showImage = "http://catchup.ninemsn.com.au/img/jump-in/shows/16KidsandCounting1280.jpg"
                },
                language = "English",
                nextEpisode = null,
                primaryColor = "#ff7800",
                seasons = new[] { new Season { slug = "show/16kidsandcounting/season/1" } },
                slug = "show/16kidsandcounting",
                title = "16 Kids and Counting",
                tvChannel = "GEM"
            });

            return request;
        }
    }
}
