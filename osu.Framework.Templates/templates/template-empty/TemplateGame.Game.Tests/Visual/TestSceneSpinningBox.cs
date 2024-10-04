using osu.Framework.Graphics;
using NUnit.Framework;

namespace TemplateGame.Game.Tests.Visual
{
    [TestFixture]
    public partial class TestSceneSpinningBox : TemplateGameTestScene
    {
        // Add visual tests to ensure correct behaviour of your game: ./osu.Framework.wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        public TestSceneSpinningBox()
        {
            Add(new SpinningBox
            {
                Anchor = Anchor.Centre,
            });
        }
    }
}
