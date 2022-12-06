namespace Main;

public class Artist
{
    private string firstName;
    private string lastName;
    private int birthYear;
    private Album[] albums;
    private Song[] singles;

    public string FirstName => firstName;
    public string LastName => lastName;
    public int BirthYear => birthYear;
    public Album[] Albums => albums;
    public Song[] Singles => singles;

    public Artist(string firstName, string lastName, int birthYear, Album[] albums, Song[] singles)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthYear = birthYear;
        this.albums = albums;
        this.singles = singles;
    }

    public Song mostLikedSong()
    {
        int maxlike = Singles.Max(x => x.Likes);
        Song song = Singles.First(x => x.Likes == maxlike);

        for (int i = 0; i <= Albums.Length-1; i++)
        {
                int templike = Albums[i].Songs.Max(x => x.Likes);   //get max Likes form albums Ith Song[].
                Song tempsong = Albums[i].Songs.First(x => x.Likes == templike);
                if (templike > maxlike)
                {
                    song = tempsong;
                }
        }
        return song;
    }

    public Song LeastLikedSong()
    {
        int maxlike = Singles.Min(x => x.Likes);
        Song song = Singles.First(x => x.Likes == maxlike);

        for (int i = 0; i <= Albums.Length-1; i++)
        {
            int templike = Albums[i].Songs.Min(x => x.Likes);   //get max Likes form albums Ith Song[].
            Song tempsong = Albums[i].Songs.First(x => x.Likes == templike);
            if (templike < maxlike)
            {
                song = tempsong;
            }
        }
        return song;
        
    }

    public int TotalLikes()
    {
        int sum = Singles.Sum(x => x.Likes);

        for (int i = 0; i <= Albums.Length-1; i++)
        {
            sum += Albums[i].Songs.Sum(x => x.Likes);   //get max Likes form albums Ith Song[].
        }
        return sum;
    }

    public Boolean IsEqual(Artist other)
    {
        if (this.firstName == other.firstName && this.lastName == other.lastName && this.birthYear == other.birthYear)
        {
            return true;
        }

        return false;
    }

    public String ToString()
    {
        return " Name: " + FirstName +
               " Lastname: " + LastName +
               " Birth Year: " + BirthYear +
               " Total Likes: " + TotalLikes();

    }
    
    
}