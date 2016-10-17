using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.Models;
using Moq;

namespace TaskManager.Tests
{
    [TestClass]
    public class TestTaskManager
    {
        [TestMethod]
        public void TaskManager_AddingTask_ShouldCallLog()
        {

            // Arrange

            var mLogger = new Mock<ILogger>();
            var mId = new Mock<IIDProvider>();

            var taskManager = new Tasker(mLogger.Object, mId.Object);

            mLogger.Setup(x => x.Log(It.IsAny<string>()));

            var mTask = new Task("");
            // Act

            taskManager.Save(mTask);
            // Assert

            mLogger.Verify();
        }

        public class MockedLogger : ILogger
        {
            public bool IsLogCalled;

            public void Log(string msg)
            {
                IsLogCalled = true;
            }
        }

        public class MockedIdProvider : IIDProvider
        {

            public int Id
            {
                get
                {
                    return 1;
                }
            }

        }
    }
}
