using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;

namespace Presso
{
    public class PartialProperties
    {
        public PartialProperties()
        {
            //https://www.youtube.com/watch?v=wRMUvjUVMlc&t=27s
            //idea validation library
            var likesCounter = new LikeCounter();
            likesCounter.Likes = 10;
            likesCounter.Test = "Hello";
            //likesCounter.Test = "";
            Console.WriteLine(likesCounter.Likes);
        }

    }

    public partial class LikeCounter
    {
        public partial int Likes { get; set; }
        public partial string Test { get; set; }
    }

    public partial class LikeCounter
    {
        private int _likes = 0;

        public partial int Likes
        {
            get { return _likes; }
            set { _likes = value; }
        }


        public partial string Test
        {

            get;
            set => field = !String.IsNullOrEmpty(value)
                ? value
                : throw new System.ArgumentException(nameof(value), "Must not be empty.");
        }
    }

}
