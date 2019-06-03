# Hello World


## Build Status
[![Build Status](https://travis-ci.org/mihirpsheth/CI.svg?branch=master)](https://travis-ci.org/mihirpsheth/CI)

## About

Hello World is a sample program which is written in C# .net core, it triggers pipeline in Travis CI to builds the application on each commit.

## Prerequisites

The application being .net core app, you will need to install [.NET Core Windows Server Hosting Bundle](https://dotnet.microsoft.com/download/dotnet-core/2.2) 
Add a new application pool with .Net CLR version as "No Managed Code"

# Deploy

Using Deloy -> Import Application, import the package file and change the appliction pool to the application pool which support No Managed code (the one created in prerequisites).

## API

**Hello World Endpoint** : [base-url]/api/HelloWorld

[![Hello World API](https://github.com/mihirpsheth/CI/blob/master/Raw/HelloWorldAP "Hello World API")](https://github.com/mihirpsheth/CI/blob/master/Raw/HelloWorldAP "Hello World API")

**Metadata Endpoint** : [base-url]/api/Metadata

[![Metadata API](https://github.com/mihirpsheth/CI/blob/master/Raw/Metadata.png "Metadata API")](https://github.com/mihirpsheth/CI/blob/master/Raw/Metadata.png "Metadata API")

Health Endpoint: [base-url]/healthchecks-api

[![Health API](https://github.com/mihirpsheth/CI/blob/master/Raw/Health%20API.png "Health API")](https://github.com/mihirpsheth/CI/blob/master/Raw/Health%20API.png "Health API")


## Health Page

[base-url]/UI

Uses Health Endpoint with HealthCheck UI nuget package to give the nice layout.

[![Health UI](https://github.com/mihirpsheth/CI/blob/master/Raw/Health.png "Health UI")](https://github.com/mihirpsheth/CI/blob/master/Raw/Health.png "Health UI")

Note: Report Endpoint intentionally fails for demonstration purpose.

# Build

Using Travis CI, the auto build is triggered, see Build Status.
