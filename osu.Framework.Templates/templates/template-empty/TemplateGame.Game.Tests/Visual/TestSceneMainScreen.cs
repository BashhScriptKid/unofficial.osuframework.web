using osu.Framework.Graphics;
using osu.Framework.Screens;
using NUnit.Framework;

namespace TemplateGame.Game.Tests.Visual
{
    [TestFixture]
    public partial class TestSceneMainScreen : TemplateGameTestScene
    {
        // Add visual tests to ensure correct behaviour of your game: ./osu.Framework.wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        public TestSceneMainScreen()
        {
            Add(new ScreenStack(new MainScreen()) { RelativeSizeAxes = Axes.Both });
        }
    }
}
