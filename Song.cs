namespace Main;

public class Song
{
    private string title;
    private int releaseYear;
    private int duration;
    private int likes;
    
    public string Title => title;
    public int ReleaseYear => releaseYear;
    public int Duration => duration;
    public int Likes => likes;

    public Song(string title, int releaseYear, int duration, int likes)
    {
        this.title = title;
        this.releaseYear = releaseYear;
        this.duration = duration;
        this.likes = likes;
    }
    
    public Song(string title, int releaseYear)
    {
        this.title = title;
        this.releaseYear = releaseYear;
        this.duration = 60;
        this.likes = 0;
    }
   
    public Song (string title, int releaseYear, int likes)
    {
        this.title = title;
        this.releaseYear = releaseYear;
        this.duration = 60;
        this.likes = likes;
    }
    
    public Song (int releaseYear,string title, int duration)
    {
        this.title = title;
        this.releaseYear = releaseYear;
        this.duration = duration;
        this.likes = 0;
    }
    
    

    
    public Boolean changeDuration(int duration)
    {
        if (duration < 0 || duration > 720 || duration == this.duration)
        {
            return false;
        }
        else
        {
            this.duration = duration;
            return true;
        }
        
    }

    public void like()
    {
        this.likes++;
    }

    public void unlike()
    {
        if (this.likes > 0)
        {
            this.likes--;

        }
    }

    public String ToString()
    {
        return " Title: " + this.title + 
               " Duration: " + Convert.ToDouble((this.duration))/60.0 +
               " Release Year: " + this.releaseYear +
               " Likes: " + this.likes;
    }

    public Boolean isEqual(Song other)
    {
        if (this.title == other.title && this.duration == other.duration && this.releaseYear == other.releaseYear)
        {
            return true;
        }
        return false;
    }

   
    
}