﻿using System;
using System.Collections.Generic;
using Xunit;
using Whatfits.DataAccess.Gateways.CoreGateways;
using Whatfits.DataAccess.DataTransferObjects.CoreDTOs;
using System.Security.Claims;
namespace Gateway.Tester
{
    /// <summary>
    /// Tests each method in the UserAccessGateway
    /// </summary>
    public class UserAccessControlTests
    {
        private UserAccessControlGateway uac = new UserAccessControlGateway();
        [Fact]
        public void AddUserClaimTest()
        {
            // By default rblue only has ClaimType and ClaimValue3, ClaimType and ClaimValue1
            UserAccessDTO userName = new UserAccessDTO
            {
                UserName = "rblue",
                UserClaims = new List<Claim>()
                {
                    new Claim("NewClaimType", "NewClaimValue")
                }

            };
            Assert.True(uac.AddUserClaims(userName));
        }
        [Fact]
        public void RemoveUserClaimTest()
        {
            // This test should remove all claims for chackins UserId=5
            UserAccessDTO username = new UserAccessDTO
            {
                UserName = "chackins",
                UserClaims = new List<Claim>
                {
                    new Claim("ClaimType","ClaimValue3"),
                    new Claim("ClaimType","ClaimValue1")
                }
            };
            Assert.True(uac.RemoveUserClaims(username));
        }
        [Fact]
        public void GetUserClaims()
        {
            UserAccessDTO userName = new UserAccessDTO
            {
                UserName = "amay"
            };
            List<Claim> foundClaims = uac.GetUserClaims(userName);
            List<Claim> expectedClaims = new List<Claim>
            {
                new Claim("AmayClaimType1", "AmayClaimValue1"),
                new Claim("AmayClaimType2", "AmayClaimValue2"),
            };
            Assert.Equal(expectedClaims,foundClaims);
        }
    }
}
