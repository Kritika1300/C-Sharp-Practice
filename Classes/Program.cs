using System;
using System.Threading;

namespace Classes
{

    class Program
    {
        public static void Main()
        {
            var video = new Video() { Title = "First video" };

            //subscribe MailService to VideoEncoded event of VideoEncoder class

            var videoEncoder = new VideoEncoder();// publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //registering event handler
            // event has list of pointers/reference to event handlers
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
                                                               
            videoEncoder.Encode(video);

          
        }
    }
    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder 
    {


        public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video.....");
            Thread.Sleep(3000);

            OnVideoEncoded(video); // to notify subscribers
            
        }

        // to raise an event we need a method -> Publisher Method
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null) //checks if there are subscribers
            {
                VideoEncoded(this, new VideoEventArgs(){ Video = video});
                           //who is publishing, additional info to be passed 
            }

        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) //Event Handler
        {
            Console.WriteLine("Sending Mail....." + e.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) //Event Handler
        {
            Console.WriteLine("Sending Message....."+ e.Video.Title);
        }
    }



}




