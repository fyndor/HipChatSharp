using HipChatSharp.Abstractions;
using HipChatSharp.Core;
using HipChatSharp.Models;
using Moq;
using Xunit;

namespace HipChatSharp.Tests.Core
{
    public class HipChatClientBaseTests
    {
        [Fact]
        public void Ctor_GivenNoConfig_DefaultsAreSet()
        {
            //Arrange
            var endpointProvider = new Mock<IHipChatEndpointProvider>();
            var config = new HipChatConfig();

            //Act
            var client = new HipChatClientBase(config, endpointProvider.Object);

            //Assert
            Assert.Equal(HipChatConst.DefaultHost, client.Host);
            Assert.Equal(string.Empty, client.ApiKey);
        }

        [Fact]
        public void Ctor_GivenConfig_ConfigSettingsAreSet()
        {
            //Arrange
            var endpointProvider = new Mock<IHipChatEndpointProvider>();
            var apiKey = "FAKEAPIKEY";
            var host = "fakehost.com";
            var config = new HipChatConfig
            {
                ApiKey = apiKey,
                Host = host
            };

            //Act
            var client = new HipChatClientBase(config, endpointProvider.Object);

            //Assert
            Assert.Equal(host, client.Host);
            Assert.Equal(apiKey, client.ApiKey);
        }

        [Fact]
        public void Ctor_GivenEndpointProvider_EndpointPropertiesAssignedProvidedEndpoints()
        {
            //Arrange
            var config = new HipChatConfig();
            var endpointProvider = new Mock<IHipChatEndpointProvider>();
            var roomsEndpoint = new Mock<IHipChatRoomsEndpoint>();
            var usersEndpoint = new Mock<IHipChatUsersEndpoint>();
            var capabilitiesEndpoint = new Mock<IHipChatCapabilitiesEndpoint>();
            var emoticonsEndpoint = new Mock<IHipChatEmoticonsEndpoint>();
            var extensionsEndpoint = new Mock<IHipChatExtensionsEndpoint>();
            var flagsEndpoint = new Mock<IHipChatFlagsEndpoint>();
            var groupsEndpoint = new Mock<IHipChatGroupsEndpoint>();
            var integrationsEndpoint = new Mock<IHipChatIntegrationsEndpoint>();
            var invitesEndpoint = new Mock<IHipChatInvitesEndpoint>();
            var prefsEndpoint = new Mock<IHipChatPrefsEndpoint>();
            endpointProvider.SetupProperty(ep => ep.RoomsEndpoint, roomsEndpoint.Object);
            endpointProvider.SetupProperty(ep => ep.UsersEndpoint, usersEndpoint.Object);
            endpointProvider.SetupProperty(ep => ep.CapabilitiesEndpoint, capabilitiesEndpoint.Object);
            endpointProvider.SetupProperty(ep => ep.EmoticonsEndpoint, emoticonsEndpoint.Object);
            endpointProvider.SetupProperty(ep => ep.ExtensionsEndpoint, extensionsEndpoint.Object);
            endpointProvider.SetupProperty(ep => ep.FlagsEndpoint, flagsEndpoint.Object);
            endpointProvider.SetupProperty(ep => ep.GroupsEndpoint, groupsEndpoint.Object);
            endpointProvider.SetupProperty(ep => ep.IntegrationsEndpoint, integrationsEndpoint.Object);
            endpointProvider.SetupProperty(ep => ep.InvitesEndpoint, invitesEndpoint.Object);
            endpointProvider.SetupProperty(ep => ep.PrefsEndpoint, prefsEndpoint.Object);

            //Act
            var client = new HipChatClientBase(config, endpointProvider.Object);

            //Assert
            Assert.Equal(roomsEndpoint.Object, client.Rooms);
            Assert.Equal(usersEndpoint.Object, client.Users);
            Assert.Equal(capabilitiesEndpoint.Object, client.Capabilities);
            Assert.Equal(emoticonsEndpoint.Object, client.Emoticons);
            Assert.Equal(extensionsEndpoint.Object, client.Extensions);
            Assert.Equal(flagsEndpoint.Object, client.Flags);
            Assert.Equal(groupsEndpoint.Object, client.Groups);
            Assert.Equal(integrationsEndpoint.Object, client.Integrations);
            Assert.Equal(invitesEndpoint.Object, client.Invites);
            Assert.Equal(prefsEndpoint.Object, client.Prefs);
        }
    }
}
