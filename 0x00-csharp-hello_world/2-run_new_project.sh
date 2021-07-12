#!/usr/bin/env bash
# Bash script that initializes, builds, and runs a new C# project from a folder titled 2-new_project.
dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run --project 2-new_project
