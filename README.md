# Hello World


## Build Status from Travis CI
[![Build Status](https://travis-ci.org/mihirpsheth/CI.svg?branch=master)](https://travis-ci.org/mihirpsheth/CI)


## Build Status from Azure Pipelines
[![Build Status](https://dev.azure.com/mihiroffer/CI/_apis/build/status/mihirpsheth.CI?branchName=master)](https://dev.azure.com/mihiroffer/CI/_build/latest?definitionId=1&branchName=master)

=============

## About

Hello World is a sample program which is written in C# .net core, it triggers pipeline in Travis CI to builds the application on each commit.

## Prerequisites

The application being .net core app, you will need to install [.NET Core Windows Server Hosting Bundle](https://dotnet.microsoft.com/download/dotnet-core/2.2) 

Add a new application pool with .Net CLR version as "No Managed Code"

[![](https://github.com/mihirpsheth/CI/blob/master/Raw/AppPool.png)](https://github.com/mihirpsheth/CI/blob/master/Raw/AppPool.png)

## Deploy

Using Deloy -> Import Application, import the [package file](https://github.com/mihirpsheth/CI/blob/master/HelloWorld.zip) and change the appliction pool of the application deployed to the application pool which support No Managed code (the one created in prerequisites).

## API

**Hello World Endpoint** : [base-url]/api/HelloWorld

[![Hello World API](https://github.com/mihirpsheth/CI/blob/master/Raw/HelloWorldAPI.png "Hello World API")](https://github.com/mihirpsheth/CI/blob/master/Raw/HelloWorldAPI.png "Hello World API")

**Metadata Endpoint** : [base-url]/api/Metadata

[![Metadata API](https://github.com/mihirpsheth/CI/blob/master/Raw/Metadata.png "Metadata API")](https://github.com/mihirpsheth/CI/blob/master/Raw/Metadata.png "Metadata API")

**Health Endpoint:** [base-url]/healthchecks-api

[![Health API](https://github.com/mihirpsheth/CI/blob/master/Raw/Health%20API.png "Health API")](https://github.com/mihirpsheth/CI/blob/master/Raw/Health%20API.png "Health API")


## Health Page

[base-url]/UI

Uses Health Endpoint with HealthCheck UI nuget package to give the nice layout.

[![Health UI](https://github.com/mihirpsheth/CI/blob/master/Raw/Health.png "Health UI")](https://github.com/mihirpsheth/CI/blob/master/Raw/Health.png "Health UI")

Note: Report Endpoint intentionally fails for demonstration purpose.

## Build

Using Travis CI, the auto build is triggered, see Build Status or visit [Travis-CI Page](https://travis-ci.org/mihirpsheth/CI)

## Regression Test

Using [Postman](https://www.getpostman.com/downloads/), import the [Test file](https://github.com/mihirpsheth/CI/blob/master/Hello%20World.postman_collection.json).

You will need to change the base url in Manage Environment before you run these tests:

[![](https://github.com/mihirpsheth/CI/blob/master/Raw/Postman.png)](https://github.com/mihirpsheth/CI/blob/master/Raw/Postman.png)
