using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presso
{
    public class FieldKeyword
    {
        public FieldKeyword()
        {
            var p = new Post();
            p.Title = "Hello";
            // p.Title = "";

            var op = new OldPost();
            op.Title = "Hello";
            // op.Title = "";
        }



        class Post
        {
            public string Title
            {
                get;
                set => field = !String.IsNullOrEmpty(value) ? value : throw new ArgumentException(nameof(value), "Must not be empty.");
            }
        }

        class OldPost
        {
            private string title;
            public string Title
            {
                get => title;
                set => title = !String.IsNullOrEmpty(value) ? value : throw new ArgumentException(nameof(value), "Must not be empty.");
            }
        }
    }
}
