using System.Collections;

namespace Main;



public class Album
{
    private String title;
    private int releaseYear;
    private Song[] songs;

    public string Title => title;
    public int ReleaseYear => releaseYear;
    public Song[] Songs => songs;

    public Album(string title, int releaseYear)
    {
        this.title = title;
        this.releaseYear = releaseYear;
    }

    public int addSongs(Song[] Collections)
    {
        int counter = 0;
        List<Song> songslist = new List<Song>();
        if (this.songs != null)
        {
            songslist = this.songs.ToList();
        }
        for (int i = 0; i < Collections.Length; i++)
        {
            if (!songslist.Contains(Collections[i]))
            {
             songslist.Add(Collections[i]);
             counter++;
            }
        }

        this.songs = songslist.ToArray();

        return counter;
    }
    public Song[] Shuffle()  //returns songs with random order
    {
        Random rand = new Random();

        for (int i = 0; i < this.songs.Length; i++)
        {
            int randomint = rand.Next(this.songs.Length);
            Song tmp = songs[i];
            songs[i] = songs[randomint];
            songs[randomint] = tmp;

        }
        return songs;
    }

    public Song[] SortByTitle(Boolean IsAscending) // sort Collection of songs according lexicographical comparison of song titles
    {
        if (IsAscending == true)
        {
            Song[] sorted = new Song[this.songs.Length];
            Array.Sort(this.songs, (x, y) => x.Title.CompareTo(y.Title));
            sorted = songs;
            return sorted;
            
        }
        else
        {
            Song[] sorted = new Song[this.songs.Length];
            Array.Sort(this.songs, (x, y) => x.Title.CompareTo(y.Title));
            sorted = songs;
            sorted = Enumerable.Reverse(sorted).ToArray();
            return sorted;
        }
        
    }

    public Song[] SortByDuration(Boolean IsAscending)
    {
        if (IsAscending == true)
        {
            Song[] sorted = new Song[this.songs.Length];
            Array.Sort(this.songs, (x, y) => x.Duration.CompareTo(y.Duration));
            sorted = songs;
            return sorted;
            
        }
        else
        {
            Song[] sorted = new Song[this.songs.Length];
            Array.Sort(this.songs, (x, y) => x.Duration.CompareTo(y.Duration));
            sorted = songs;
            sorted = Enumerable.Reverse(sorted).ToArray();
            return sorted;
        }
        
    }

    public Song[] SortByReleaseYear(Boolean IsAscending)
    {
        if (IsAscending == true)
        {
            Song[] sorted = new Song[this.songs.Length];
            Array.Sort(this.songs, (x, y) => x.ReleaseYear.CompareTo(y.ReleaseYear));
            sorted = songs;
            return sorted;
            
        }
        else
        {
            Song[] sorted = new Song[this.songs.Length];
            Array.Sort(this.songs, (x, y) => x.ReleaseYear.CompareTo(y.ReleaseYear));
            sorted = songs;
            sorted = Enumerable.Reverse(sorted).ToArray();
            return sorted;
        }
        
    }
    
    public Song[] SortByPopularity(Boolean IsAscending)
    {
        if (IsAscending == true)
        {
            Song[] sorted = new Song[this.songs.Length];
            Array.Sort(this.songs, (x, y) => x.Likes.CompareTo(y.Likes));
            sorted = songs;
            return sorted;
            
        }
        else
        {
            Song[] sorted = new Song[this.songs.Length];
            Array.Sort(this.songs, (x, y) => x.Likes.CompareTo(y.Likes));
            sorted = songs;
            sorted = Enumerable.Reverse(sorted).ToArray();
            return sorted;
        }
        
    }

    public Song[] reverse(Song[] arr)
    {
        return Enumerable.Reverse(arr).ToArray();
    }
    public String ToString()
    {
        String songtotext = "";
        for (int i = 0; i < songs.Length-1; i++)
        {
            songtotext += "" + songs[i].ToString();

        }

        return "Title: " + this.title +
               " Release year: " + this.releaseYear +
               " songs: " + "{" + songtotext + "}";
    }
}