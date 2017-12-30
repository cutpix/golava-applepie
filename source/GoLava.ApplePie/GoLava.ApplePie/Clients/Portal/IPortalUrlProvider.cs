﻿namespace GoLava.ApplePie.Clients.Portal
{
    public interface IPortalUrlProvider : IUrlProvider
    {
        string GetApplicationsUrl { get; }

        string GetApplicationDetailsUrl { get; }

        string GetDevicesUrl { get; }

        string AddDevicesUrl { get; }

        string DeleteDeviceUrl { get; }

        string EnableDeviceUrl { get; }

        string UpdateDeviceUrl { get; }

        string GetTeamsUrl { get; }

        string GetTeamMembersUrl { get; }

        string GetTeamInvitesUrl { get; }
    }
}