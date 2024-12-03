using BenchmarkDotNet.Running;
namespace WhatsNew
{
    internal class Program
    {
        /*
         * https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13
         * https://www.syncfusion.com/blogs/post/whats-new-csharp-13-for-developers
         * https://www.reddit.com/r/dotnet/comments/1g9ighp/whats_new_in_c_13_overview/
         * https://dev.to/pvsdev/whats-new-in-c-13-overview-3n9o
         * https://medium.com/@raindefiance/c-13-new-features-explained-76bb6c4e59bf
         * https://www.linkedin.com/pulse/c-13-net-9-whats-new-language-mark-j-price-z8lee
         * https://www.infoq.com/news/2024/05/csharp-13-preview/
         * https://www.dotnetoffice.com/2024/05/whats-new-in-c-13-c-13-new-features_25.html
         * https://www.c-sharpcorner.com/article/whats-new-in-c-sharp-13/
         * https://dev.to/priyanka_bhattacharjee_dd/unveiling-the-latest-in-c-13-key-features-and-enhancements-1b0h
         * https://www.youtube.com/playlist?list=PLUOequmGnXxOg34RURcrevdSC3sOZ8aBn
         * https://news.ycombinator.com/item?id=40530780
         * https://app.daily.dev/posts/c-13-features-what-s-new-and-how-to-use-it-7el3yjfki
         *
         * Method group natural type improvements
         * Enable ref struct types to implement interfaces.
         */
        static async Task Main(string[] args)
        {

            var orpa = new OverloadResolutionPriorityAttribute();

            var ria = new RefInAsync();
            await ria.AsyncMethod();

            var rs = new RefStruct();

            var arl = new AllowRefStruct();

            var pp = new PartialProperties();
            var ns = new NewSpan();

            var iia = new ImplicitIndexAccess();
            var nl = new NewLinq();
            var pc = new ParamsCollections();


            var fk = new FieldKeyword();


            var esc = new CharacterLiteralEscapeSequence();

            var fs = new FeatureSwitch();



        }
    }
}
