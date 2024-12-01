using BenchmarkDotNet.Running;
namespace Presso
{
    internal class Program
    {
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
