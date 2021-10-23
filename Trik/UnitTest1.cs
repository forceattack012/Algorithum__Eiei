using System;
using Xunit;

namespace Trik
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TrikGame trikGame = new TrikGame("AB");
            trikGame.FindPositionOfBall();

            Assert.Equal(3, trikGame.Position);

            TrikGame trik = new TrikGame("CBABCACCC");
            trik.FindPositionOfBall();

            Assert.Equal(1, trik.Position);
        }


        [Fact]
        public void Test2()
        {
            TrikGame trikGame = new TrikGame("AAA");
            trikGame.FindPositionOfBall();

            Assert.Equal(2, trikGame.Position);

            TrikGame trik = new TrikGame("BBB");
            trik.FindPositionOfBall();

            Assert.Equal(1, trik.Position);
        }


        [Fact]
        public void Test3()
        {
            TrikGame trikGame = new TrikGame("BBC");
            trikGame.FindPositionOfBall();

            Assert.Equal(3, trikGame.Position);
        }

        [Fact]
        public void Test4()
        {
            try
            {
                TrikGame trikGame = new TrikGame("BBCZ");
            }
            catch(Exception ex)
            {
                Assert.NotEmpty(ex.Message);
            }
        }
    }
}
