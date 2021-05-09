using Human;

namespace Alex
{
    static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while(true)
                {
                   Watch("https://www.youtube.com/");
                }
            }
            catch(Exception e)
            {
                // do nothing
            }
        }
    }
}
