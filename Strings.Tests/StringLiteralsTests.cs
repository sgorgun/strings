using NUnit.Framework;

// ReSharper disable StringLiteralTypo
// ReSharper disable IdentifierTypo
namespace Strings.Tests
{
    [TestFixture]
    public sealed class StringLiteralsTests
    {
        [Test]
        public void ReturnAbcStringLiteral()
        {
            // Act
            string actualResult = StringLiterals.ReturnAbcStringLiteral();

            // Assert
            Assert.AreEqual("abc", actualResult);
        }

        [Test]
        public void ReturnAbcdefStringLiteral()
        {
            // Act
            string actualResult = StringLiterals.ReturnAbcdefStringLiteral();

            // Assert
            Assert.AreEqual("ABCDEF", actualResult);
        }

        [Test]
        public void ReturnEmptyString()
        {
            // Act
            string result = StringLiterals.ReturnEmptyString();

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void ReturnFilePathStringLiteral1()
        {
            // Act
            string actualResult = StringLiterals.ReturnFilePathStringLiteral1();

            // Assert
            Assert.AreEqual("c:\\documents\\files\\myfile0234.txt", actualResult);
        }

        [Test]
        public void ReturnFilePathStringLiteral2()
        {
            // Act
            string actualResult = StringLiterals.ReturnFilePathStringLiteral2();

            // Assert
            Assert.AreEqual("c:\\users\\myuser\\documents\\my-video-file.avi", actualResult);
        }

        [Test]
        public void ReturnFilePathVerbatimStringLiteral1()
        {
            // Act
            string actualResult = StringLiterals.ReturnFilePathVerbatimStringLiteral1();

            // Assert
            Assert.AreEqual(@"c:\documents\files\datafile0582.txt", actualResult);
        }

        [Test]
        public void ReturnFilePathVerbatimStringLiteral2()
        {
            // Act
            string actualResult = StringLiterals.ReturnFilePathVerbatimStringLiteral2();

            // Assert
            Assert.AreEqual(@"c:\users\myuser\documents\my-audio-file.mp3", actualResult);
        }
    }
}
