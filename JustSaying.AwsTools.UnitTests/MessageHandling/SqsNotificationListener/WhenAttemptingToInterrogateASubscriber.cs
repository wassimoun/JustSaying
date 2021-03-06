using System.Linq;
using JustBehave;
using JustSaying.TestingFramework;
using Shouldly;

namespace JustSaying.AwsTools.UnitTests.MessageHandling.SqsNotificationListener
{
    public class WhenAttemptingToInterrogateASubscriber : BaseQueuePollingTest
    {
        [Then]
        public void SubscriptedMessagesAreAddedToTheInterrogationDetails()
        {
            SystemUnderTest.Subscribers.Count.ShouldBe(1);
            SystemUnderTest.Subscribers.First(x => x.MessageType == typeof (GenericMessage)).ShouldNotBe(null);
        }
    }
}