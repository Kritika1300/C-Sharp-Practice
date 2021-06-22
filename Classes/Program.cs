﻿using System;
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

    public class VideoEncoder 
    {
        public delegate void VideoEncodedEventHnadler(object source, EventArgs args); //define delegate

        public event VideoEncodedEventHnadler VideoEncoded; //define event

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video.....");
            Thread.Sleep(3000);

            OnVideoEncoded(); // to notify subscribers
            
        }

        // to raise an event we need a method -> Publisher Method
        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null) //checks if there are subscribers
            {
                VideoEncoded(this, EventArgs.Empty);
                           //who is publishing, additional info to be passed 
            }

        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e) //Event Handler
        {
            Console.WriteLine("Sending Mail.....");
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e) //Event Handler
        {
            Console.WriteLine("Sending Message.....");
        }
    }



}




