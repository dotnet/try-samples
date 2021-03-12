# CI and PR triggers
trigger:
- main
pr:
- main

jobs:
- job: Windows
  pool:
    vmImage: windows-2019
    
  steps:
   - task: UseDotNet@2
     displayName: 'Use .NET Core sdk'
     inputs:
       packageType: sdk
       version: 3.1.200
       installationPath: $(Agent.ToolsDirectory)/dotnet
   - task: UseDotNet@2
     displayName: 'Use .NET Core sdk'
     inputs:
       packageType: sdk
       version: 2.1.700
       installationPath: $(Agent.ToolsDirectory)/dotnet
   - script: build.cmd
