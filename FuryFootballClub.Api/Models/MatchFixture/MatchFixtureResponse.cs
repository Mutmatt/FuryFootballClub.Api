﻿using System;

namespace FuryFootballClub.Api.Models.MatchFixture
{
    public class MatchFixtureResponse
    {
        public Guid Guid { get; set; }
        public ResponseStatus Status { get; set; }
    }
}