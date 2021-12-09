using System;

namespace Classes
{
    public class Album
    {
        private bool _downloaded;
        public string Name {get; set;}
      
      public void play()
      {
            if(_downloaded == true )
            {
                Console.WriteLine("Album is playing");
            }
            else{
                Console.WriteLine("album must be downloaded first before playing");
            }
      }
}
}