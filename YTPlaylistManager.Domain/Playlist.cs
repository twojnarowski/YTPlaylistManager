namespace YTPlaylistManager.Domain;

/// <summary>
/// Stores information about a Youtube Playlist.
/// </summary>
public class Playlist
{
    public string Id { get; set; }
    public string Link { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public long ItemsCount { get; set; }
}