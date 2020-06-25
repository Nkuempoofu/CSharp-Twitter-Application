﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public class TweetManagerFile : TweetManager  // inherit from the tweetmanager
    {
        private string filename = "tweets.txt"; // filename - file name on disk 

        public override string WriteTweet(string tweet) 
        {
            


            System.IO.File.AppendAllLines(filename, new string[] { tweet });


            return " Tweet posted successfully.";
        }


        public override int TweetCounter()  
        {
            if (System.IO.File.Exists(filename))
                return System.IO.File.ReadAllLines(filename).Length;
            else
                return 0;
        }

        public override string[] GetTweets() 
        {
            if (System.IO.File.Exists(filename))
                return System.IO.File.ReadAllLines(filename); // to read all files from the filename/disk 
            else
                return new string[0];
        }
    }
}
