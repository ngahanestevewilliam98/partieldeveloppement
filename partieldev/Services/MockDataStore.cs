using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using partieldev.Models;

namespace partieldev.Services
{
    public class MockDataStore : IDataStore<Video>
    {
        readonly List<Video> items;

        public MockDataStore()
        {
            items = new List<Video>()
            {
                new Video { Id = Guid.NewGuid().ToString(), Text = "Le discours", Description="Le Discours est un film français réalisé par Laurent Tirard et sorti en 2020. Il s'agit d'une adaptation du roman du même nom de Fabrice Caro paru en 2018.", ImageUrl="https://medias.unifrance.org/medias/143/121/227727/format_page/les-films-sur-mesure.jpg", Category="Comdey", VideoUrl="https://www.youtube.com/watch?v=_5HaXedjENc", Likes="6", Dislikes="8", Language="English", Duration="1h20", Note="8.1", Price="$24", PlayingDate="June 21, 2022" },
                new Video { Id = Guid.NewGuid().ToString(), Text = "Spiderman - No way to home", Description="Film américain réalisé par Sam Raimi, sorti en 2002. C'est l'adaptation cinématographique du comics de Marvel Spider-Man", ImageUrl="https://fr.web.img6.acsta.net/pictures/21/11/29/09/54/5569118.jpg", Category="Comdey", VideoUrl="https://www.youtube.com/watch?v=UP2XoGfhJ1Y", Likes="3", Dislikes="8", Language="French", Duration="2h54", Note="6.9", Price="$24", PlayingDate="September 30, 2022" },
                new Video { Id = Guid.NewGuid().ToString(), Text = "Au coeur du bois", Description="Un doc aidé profondément humain, à voir depuis ce 8 décembre 2022", ImageUrl="https://www.nourfilms.com/wp-content/uploads/2020/12/AU-COEUR-DU-BOIS_affiche-principale.jpg", Category="Vaccance", VideoUrl="https://www.youtube.com/watch?v=EPXz7700lfY", Likes="6", Dislikes="1", Language="French", Duration="1h24", Note="9.2", Price="$24", PlayingDate="December 8, 2022" },
                new Video { Id = Guid.NewGuid().ToString(), Text = "Personne ne sort d'ici vivant (Netflix)",  Description="Histoire de fantômes avec une héroïne prisonnière d’une maison renfermant de sombres secrets", ImageUrl="https://fr.web.img2.acsta.net/r_654_368/newsv7/21/12/24/14/20/5875282.jpg", Category="Animation", VideoUrl="https://www.youtube.com/watch?v=Cp4Rxh1ZqzA", Likes="2", Dislikes="0", Language="English", Duration="1h45", Note="9.5", Price="$24", PlayingDate="October 28, 2022" },
                new Video { Id = Guid.NewGuid().ToString(), Text = "Iron man", Description="Il raconte les origines et les débuts du personnage éponyme issu du comics publié par Marvel", ImageUrl="https://fr.web.img3.acsta.net/medias/nmedia/18/62/89/45/18876909.jpg", Category="Action", VideoUrl="https://www.youtube.com/watch?v=Cp4Rxh1ZqzA", Likes="2", Dislikes="0", Language="English", Duration="1h54", Note="8.3", Price="$24", PlayingDate="December 25, 2022" },
                new Video { Id = Guid.NewGuid().ToString(), Text = "Hitman",  Description="C'est l'adaptation cinématographique du jeu vidéo d'action d' Eidos et d' IO Interactive, Hitman : Tueur à gages", ImageUrl="https://fr.web.img5.acsta.net/pictures/15/07/09/16/16/533383.jpg", Category="Action", VideoUrl="https://www.youtube.com/watch?v=Cp4Rxh1ZqzA", Likes="2", Dislikes="0", Language="English", Duration="2h03", Note="4.1", Price="$15", PlayingDate="May 15, 2022" }
            };
        }

        public async Task<bool> AddVideoAsync(Video item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateVideoAsync(Video item)
        {
            var oldItem = items.Where((Video arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteVideoAsync(string id)
        {
            var oldItem = items.Where((Video arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Video> GetVideoAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Video>> GetVideosAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
