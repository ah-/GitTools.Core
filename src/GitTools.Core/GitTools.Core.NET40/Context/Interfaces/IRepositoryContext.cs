﻿namespace GitTools
{
    using System;

    public interface IRepositoryContext : IDisposable
    {
        IAuthenticationContext Authentication { get; }

        string Directory { get; set; }

        string Branch { get; set; }

        string Url { get; set; }
    }
}