using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public class TweetManagerMemory : TweetManager // Inherit from the tweetManager
    {
        string[] tweets = new string[10];
        int tweetCounter = 0;

        public override string WriteTweet(string tweet) // method that we can enter the class with to post the tweet
        {
            tweets[tweetCounter++] = tweet;
            return " Tweet posted successfully.";
        }


        public override int TweetCounter()  // a method that will return tweetcounter 
        {
            return tweetCounter;
        }

        public override string[] GetTweets() // returning the tweets by GetTweets() method
        {
            return tweets;
        }
    }
}
