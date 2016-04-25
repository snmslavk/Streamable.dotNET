using NUnit.Framework;
using Moq;
using Streamable.dotNET;
using Streamable.dotNET.Interfaces;
using Streamable.dotNET.Models;
using System.IO;
using System.Reflection;

namespace Streamable.Tests
{
    [TestFixture]
    class StreamableApiTests
    {
        private StreamableAPI client;
        private Mock<IWebClientExtended> webClientMoq;
        private string dir = "";

        struct ConfigVals
        {
            internal static readonly string testVideoUrl = "https://streamable.com/uz0t";
            internal static readonly string oEmbedPathTest = "oEmbedTest.json";
            internal static readonly string importRespTest = "ImportRespTest.json";
            internal static readonly string retriveUserRespTest = "RetriveUserRespTest.json";
            internal static readonly string retriveVideoRespTest = "RetriveVideoRespTest.json";
            internal static readonly string testVideoPath = "TestVideo.mp4";
        }

        [SetUp]
        public void Setup()
        {
            webClientMoq = new Mock<IWebClientExtended>();

            dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\TestData\\";

            client = new StreamableAPI(webClientMoq.Object);
        }

        [Test]
        public void GEToEmbedTest()
        {
            
            webClientMoq.Setup(
                foo => foo.GetData(
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()
                    )
                ).Returns(
                    File.ReadAllText(dir + ConfigVals.oEmbedPathTest)
                );

            Assert.IsNotNull(
                client.GEToEmbed(ConfigVals.testVideoUrl)
                );

            Assert.IsInstanceOf<oEmbedModel>(
                client.GEToEmbed(ConfigVals.testVideoUrl)
            );
        }

        [Test]
        public void RetriveUserTest()
        {
            webClientMoq.Setup(
            foo => foo.GetData(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
                )
            ).Returns(
                File.ReadAllText(dir + ConfigVals.retriveUserRespTest)
            );

            Assert.IsNotNull(
                client.RetrieveUser("")
                );

            Assert.IsInstanceOf<UserModel>(
                client.RetrieveUser("")
            );
        }

        [Test]
        public void RetriveVideoTest()
        {
            webClientMoq.Setup(
            foo => foo.GetData(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
                )
            ).Returns(
                File.ReadAllText(dir + ConfigVals.retriveVideoRespTest)
            );

            Assert.IsNotNull(
                client.Retrive("")
                );

            Assert.IsInstanceOf<RetriveVideoModel>(
                client.Retrive("")
            );
        }

        [Test]
        public void ImportVideoTest()
        {
            webClientMoq.Setup(
            foo => foo.GetData(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
                )
            ).Returns(
                File.ReadAllText(dir + ConfigVals.importRespTest)
            );

            Assert.IsNotNull(
                client.Import("")
                );

            Assert.IsInstanceOf<UploadVideoResponse>(
                client.Import("")
            );
        }

        [Test]
        public void UploadVideoTest()
        {
            webClientMoq.Setup(
                foo => foo.UploadFile(
                    It.IsAny<UploadAuthFileModel>()
                    )
                ).Returns(new UploadVideoResponse());

            webClientMoq.Setup(
                foo => foo.UploadFile(
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()
                    )
                ).Returns(new UploadVideoResponse());

            Assert.IsNotNull(
                client.Upload(dir + ConfigVals.testVideoPath)
                );

            Assert.IsInstanceOf<UploadVideoResponse>(
                client.Upload(dir + ConfigVals.testVideoPath)
            );
        }
    }
}
