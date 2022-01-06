using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace partieldev.Services
{
    public interface IDataStore<Video>
    {
        Task<bool> AddVideoAsync(Video item);
        Task<bool> UpdateVideoAsync(Video item);
        Task<bool> DeleteVideoAsync(string id);
        Task<Video> GetVideoAsync(string id);
        Task<IEnumerable<Video>> GetVideosAsync(bool forceRefresh = false);
    }
}
