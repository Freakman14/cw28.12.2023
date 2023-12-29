public class PhotoBooks
{
    private int numPage;
    public int page
    {
        get
        {
            return numPage;
        }
        set
        {
            numPage = value;
        }
    }
    public PhotoBooks()
    {
        numPage = 16;
    }
    public void GetNumberPages()
    {
        System.Console.WriteLine(numPage);
    }

}