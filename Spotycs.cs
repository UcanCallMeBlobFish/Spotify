namespace Main;

public class Spotycs
{
    private Artist[] artists;

    public Spotycs()
    {
    }

    public Artist[] GetArtists()
    {
        return this.artists;
    }

    public void addArtists(Artist[] oth)
    {
        List<Artist> artlist = new List<Artist>();
        if (this.artists != null)
        {
            artlist = this.artists.ToList();
        }

        for (int i = 0; i < oth.Length; i++)
        {
            if (!artlist.Contains(oth[i]))
            {
                artlist.Add(oth[i]);
            }
            
        }
        this.artists = artlist.ToArray();
    }

    public String[] GetTopTrendingArtist()
    {
        int min = 0;
        Artist mostliked = artists[0];
        for (int i = 0; i <= artists.Length-1; i++)
        {
            if (artists[i].TotalLikes() > min)
            {
                min = artists[i].TotalLikes();
                mostliked = artists[i];

            }
        }

        String[] final = new[] { mostliked.FirstName, mostliked.LastName };
        return final;
    }
    
}